using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RabbitMQ.Consumer
{
    public class RabbitMQ
    {

        #region DemoCode

        private static IConnection _rabbitMQConnection;

        private static IModel _rabbitMQModel;

        /// <summary>
        /// RabbitMQ 连接
        /// 注：不要频繁创建连接，尽量复用
        /// </summary>
        public static IConnection Connection
        {
            get
            {
                // 连接工厂创建方式一（通过配置连接参数属性）
                var GetConnFromPropConfig = new Func<IConnection>(() =>
                {
                    var factory = new ConnectionFactory();

                    // 这些都是默认的连接配置
                    //factory.UserName = "guest";
                    //factory.Password = "guest";
                    //factory.VirtualHost = "/";
                    //factory.HostName = "localhost";
                    return factory.CreateConnection("ConsumerConnection");
                });

                // 连接工厂创建方式二（通过配置Uri）
                var GetConnFromUriConfig = new Func<IConnection>(() =>
                {
                    var factory = new ConnectionFactory();
                    //factory.Uri = new Uri("amqp://user:pass@hostName:port/vhost");
                    factory.Uri = new Uri("amqp://guest:guest@localhost:5672//");
                    return factory.CreateConnection();
                });

                if (_rabbitMQConnection == null)
                    _rabbitMQConnection = GetConnFromPropConfig();

                return _rabbitMQConnection;
            }
        }

        public static IModel Channel
        {
            get
            {
                if (_rabbitMQModel == null)
                    _rabbitMQModel = Connection.CreateModel();

                return _rabbitMQModel;
            }
        }


        /// <summary>
        /// 关闭 RabbitMQ 连接
        /// 注意：不建议频繁创建和关闭连接
        /// </summary>
        public void CloseRabbitMQConnection() => _rabbitMQConnection?.Close();

        

        #endregion
    }
}
