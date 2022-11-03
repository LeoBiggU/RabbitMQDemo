using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RabbitMQ.Consumer
{
    public partial class Consumer : UIForm
    {
        /// <summary>
        /// 交换机名称
        /// </summary>
        private const string ExchangeName = "PX";

        /// <summary>
        /// 队列名称
        /// </summary>
        private const string QueueName = "TESTQ";

        /// <summary>
        /// 队列名称
        /// </summary>
        private const string RoutingKey = "TQ";

        /// <summary>
        /// 订阅消费者的消费Tag
        /// </summary>
        private const string BasicConsumerTag = "BCT";
        private bool hasBasicConsumer = false;

        public Consumer()
        {
            InitializeComponent();
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;//设置该属性 为false
            InitRabbitMQ();
            InitConsumeType();
        }

        /// <summary>
        /// 初始化
        /// </summary>
        public void InitRabbitMQ()
        {
            // 声明交换机
            RabbitMQ.Channel.ExchangeDeclare(ExchangeName, ExchangeType.Direct);
            // 声明队列
            RabbitMQ.Channel.QueueDeclare(QueueName, exclusive: false, autoDelete: false);
            // 绑定队列到交换机
            RabbitMQ.Channel.QueueBind(QueueName, ExchangeName, RoutingKey);
        }

        /// <summary>
        /// 初始化消费类型
        /// </summary>
        public void InitConsumeType()
        {
            RBtn_SingleConsume.Checked = true;
        }

        private void GetMessage_Click(object sender, EventArgs e)
        {
            var message = Message.Text;
            Console.WriteLine();
            try
            {
                var result = RabbitMQ.Channel.BasicGet(QueueName, true);
                if (result == null) throw new Exception("未获取到新消息");
                var body = result.Body;
                AddText(Encoding.UTF8.GetString(body.ToArray()));
                ShowSuccessTip("成功获取新消息");
            }
            catch (Exception ex)
            {
                ShowErrorTip(ex.Message);
            }
        }

        public void AddText(string content)
        {
            Message.Text = $"[{DateTime.Now:HH:mm:ss}] -> " +  content 
                          + "\r\n-------------------------------------------------------\r\n"
                          + Message.Text;
        }

        private void RBtn_AutoConsume_CheckedChanged(object sender, EventArgs e)
        {
            var radioButton = sender as UIRadioButton;
            var isChecked = radioButton.Checked;

            if (!isChecked) return;

            GetMessage.Visible = false;
            Message.Height = 374;

            #region 初始化消费者(订阅模式)
            var consumer = new EventingBasicConsumer(RabbitMQ.Channel);
            consumer.Received += (s, ea) =>
            {
                var body = ea.Body.ToArray();
                var message = Encoding.UTF8.GetString(body);
                AddText(message);
                RabbitMQ.Channel.BasicAck(ea.DeliveryTag, false);
            };

            var consumerTag = RabbitMQ.Channel.BasicConsume(QueueName, false, BasicConsumerTag, consumer);

            hasBasicConsumer = true;
            #endregion
        }

        private void RBtn_SingleConsume_CheckedChanged(object sender, EventArgs e)
        {
            var radioButton = sender as UIRadioButton;
            var isChecked = radioButton.Checked;

            if (!isChecked) return; 

            GetMessage.Visible = true;
            Message.Height = 326;

            if (hasBasicConsumer)
            {
                RabbitMQ.Channel.BasicCancel(BasicConsumerTag);
                hasBasicConsumer = false;
            }
        }
    }
}
