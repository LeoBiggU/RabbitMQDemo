namespace RabbitMQ.Consumer
{
    partial class Consumer
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Message = new Sunny.UI.UITextBox();
            this.uiGroupBox1 = new Sunny.UI.UIGroupBox();
            this.GetMessage = new Sunny.UI.UIButton();
            this.uiRadioButtonGroup1 = new Sunny.UI.UIRadioButtonGroup();
            this.RBtn_AutoConsume = new Sunny.UI.UIRadioButton();
            this.RBtn_SingleConsume = new Sunny.UI.UIRadioButton();
            this.uiGroupBox1.SuspendLayout();
            this.uiRadioButtonGroup1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Message
            // 
            this.Message.ButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.Message.ButtonFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(97)))), ((int)(((byte)(198)))));
            this.Message.ButtonFillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(46)))), ((int)(((byte)(147)))));
            this.Message.ButtonRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.Message.ButtonRectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(97)))), ((int)(((byte)(198)))));
            this.Message.ButtonRectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(46)))), ((int)(((byte)(147)))));
            this.Message.ButtonSymbol = 61761;
            this.Message.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Message.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.Message.FillReadOnlyColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.Message.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Message.ForeReadOnlyColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(103)))));
            this.Message.Location = new System.Drawing.Point(14, 37);
            this.Message.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Message.Maximum = 2147483647D;
            this.Message.Minimum = -2147483648D;
            this.Message.MinimumSize = new System.Drawing.Size(1, 16);
            this.Message.Multiline = true;
            this.Message.Name = "Message";
            this.Message.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.Message.RectReadOnlyColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(178)))), ((int)(((byte)(181)))));
            this.Message.ShowScrollBar = true;
            this.Message.Size = new System.Drawing.Size(418, 326);
            this.Message.Style = Sunny.UI.UIStyle.Purple;
            this.Message.TabIndex = 1;
            this.Message.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Controls.Add(this.GetMessage);
            this.uiGroupBox1.Controls.Add(this.Message);
            this.uiGroupBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.uiGroupBox1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.uiGroupBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiGroupBox1.Location = new System.Drawing.Point(13, 35);
            this.uiGroupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiGroupBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiGroupBox1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.uiGroupBox1.Size = new System.Drawing.Size(449, 422);
            this.uiGroupBox1.Style = Sunny.UI.UIStyle.Purple;
            this.uiGroupBox1.TabIndex = 2;
            this.uiGroupBox1.Text = "Message";
            this.uiGroupBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GetMessage
            // 
            this.GetMessage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GetMessage.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.GetMessage.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.GetMessage.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(97)))), ((int)(((byte)(198)))));
            this.GetMessage.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(46)))), ((int)(((byte)(147)))));
            this.GetMessage.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(46)))), ((int)(((byte)(147)))));
            this.GetMessage.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GetMessage.Location = new System.Drawing.Point(14, 371);
            this.GetMessage.MinimumSize = new System.Drawing.Size(1, 1);
            this.GetMessage.Name = "GetMessage";
            this.GetMessage.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.GetMessage.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(97)))), ((int)(((byte)(198)))));
            this.GetMessage.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(46)))), ((int)(((byte)(147)))));
            this.GetMessage.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(46)))), ((int)(((byte)(147)))));
            this.GetMessage.Size = new System.Drawing.Size(418, 40);
            this.GetMessage.Style = Sunny.UI.UIStyle.Purple;
            this.GetMessage.TabIndex = 0;
            this.GetMessage.Text = "获取消息";
            this.GetMessage.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GetMessage.Click += new System.EventHandler(this.GetMessage_Click);
            // 
            // uiRadioButtonGroup1
            // 
            this.uiRadioButtonGroup1.Controls.Add(this.RBtn_SingleConsume);
            this.uiRadioButtonGroup1.Controls.Add(this.RBtn_AutoConsume);
            this.uiRadioButtonGroup1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.uiRadioButtonGroup1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(242)))), ((int)(((byte)(251)))));
            this.uiRadioButtonGroup1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiRadioButtonGroup1.Location = new System.Drawing.Point(470, 35);
            this.uiRadioButtonGroup1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiRadioButtonGroup1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiRadioButtonGroup1.Name = "uiRadioButtonGroup1";
            this.uiRadioButtonGroup1.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.uiRadioButtonGroup1.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.uiRadioButtonGroup1.Size = new System.Drawing.Size(317, 71);
            this.uiRadioButtonGroup1.Style = Sunny.UI.UIStyle.Purple;
            this.uiRadioButtonGroup1.TabIndex = 3;
            this.uiRadioButtonGroup1.Text = "消费模式";
            this.uiRadioButtonGroup1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RBtn_AutoConsume
            // 
            this.RBtn_AutoConsume.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RBtn_AutoConsume.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RBtn_AutoConsume.Location = new System.Drawing.Point(160, 31);
            this.RBtn_AutoConsume.MinimumSize = new System.Drawing.Size(1, 1);
            this.RBtn_AutoConsume.Name = "RBtn_AutoConsume";
            this.RBtn_AutoConsume.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.RBtn_AutoConsume.RadioButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.RBtn_AutoConsume.Size = new System.Drawing.Size(150, 29);
            this.RBtn_AutoConsume.Style = Sunny.UI.UIStyle.Purple;
            this.RBtn_AutoConsume.TabIndex = 0;
            this.RBtn_AutoConsume.Text = "订阅自动消费";
            this.RBtn_AutoConsume.CheckedChanged += new System.EventHandler(this.RBtn_AutoConsume_CheckedChanged);
            // 
            // RBtn_SingleConsume
            // 
            this.RBtn_SingleConsume.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RBtn_SingleConsume.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RBtn_SingleConsume.Location = new System.Drawing.Point(18, 31);
            this.RBtn_SingleConsume.MinimumSize = new System.Drawing.Size(1, 1);
            this.RBtn_SingleConsume.Name = "RBtn_SingleConsume";
            this.RBtn_SingleConsume.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.RBtn_SingleConsume.RadioButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.RBtn_SingleConsume.Size = new System.Drawing.Size(128, 29);
            this.RBtn_SingleConsume.Style = Sunny.UI.UIStyle.Purple;
            this.RBtn_SingleConsume.TabIndex = 1;
            this.RBtn_SingleConsume.Text = "手动单条消费";
            this.RBtn_SingleConsume.CheckedChanged += new System.EventHandler(this.RBtn_SingleConsume_CheckedChanged);
            // 
            // Consumer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 468);
            this.ControlBoxFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(97)))), ((int)(((byte)(198)))));
            this.Controls.Add(this.uiRadioButtonGroup1);
            this.Controls.Add(this.uiGroupBox1);
            this.Name = "Consumer";
            this.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.Style = Sunny.UI.UIStyle.Custom;
            this.Text = "MQ消费者";
            this.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.uiGroupBox1.ResumeLayout(false);
            this.uiRadioButtonGroup1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UITextBox Message;
        private Sunny.UI.UIGroupBox uiGroupBox1;
        private Sunny.UI.UIButton GetMessage;
        private Sunny.UI.UIRadioButtonGroup uiRadioButtonGroup1;
        private Sunny.UI.UIRadioButton RBtn_SingleConsume;
        private Sunny.UI.UIRadioButton RBtn_AutoConsume;
    }
}

