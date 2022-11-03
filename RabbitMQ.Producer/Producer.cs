using RabbitMQ.Client;
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

namespace RabbitMQ.Producer
{
    public partial class Producer : UIForm
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

        public Producer()
        {
            InitializeComponent();
            InitRabbitMQ();
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

        private void SendMessage_Click(object sender, EventArgs e)
        {
            var message = Message.Text;
            if (string.IsNullOrEmpty(message))
            {
                ShowErrorTip("请输入消息后再发送！");
                return;
            }
            // 消息体
            var body = Encoding.UTF8.GetBytes(message);
            // 设置消息持久化
            IBasicProperties properties = RabbitMQ.Channel.CreateBasicProperties();
            properties.DeliveryMode = 2;
            // 发送消息到RabbitMQ，使用RabbitMQ默认提供的交换机，默认的路由Key和队列名一致
            RabbitMQ.Channel.BasicPublish("", QueueName, properties, body);
            // 发完消息后清空输入框
            Message.Text = "";
            ShowSuccessTip("成功推送新消息~");
        }
    }
}
