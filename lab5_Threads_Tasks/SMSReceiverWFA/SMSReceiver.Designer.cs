namespace SimCorp.IMS.SMSReceiverWFA {
    partial class SMSReceiverForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.MessageListView = new System.Windows.Forms.ListView();
            this.SenderColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TextColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxOrLogic = new System.Windows.Forms.CheckBox();
            this.checkBoxAndLogic = new System.Windows.Forms.CheckBox();
            this.storageLogTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.progressBarCharge = new System.Windows.Forms.ProgressBar();
            this.checkBoxMessages = new System.Windows.Forms.CheckBox();
            this.checkBoxCharge = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 196);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(490, 57);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            this.richTextBox1.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "None",
            "Start with DateTime",
            "End with DateTime",
            "Custom",
            "Lowercase",
            "Uppercase"});
            this.comboBox1.Location = new System.Drawing.Point(122, 11);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(254, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // MessageListView
            // 
            this.MessageListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SenderColumnHeader,
            this.TextColumnHeader});
            this.MessageListView.Location = new System.Drawing.Point(12, 165);
            this.MessageListView.Name = "MessageListView";
            this.MessageListView.Size = new System.Drawing.Size(587, 255);
            this.MessageListView.TabIndex = 2;
            this.MessageListView.UseCompatibleStateImageBehavior = false;
            this.MessageListView.View = System.Windows.Forms.View.Details;
            // 
            // SenderColumnHeader
            // 
            this.SenderColumnHeader.Text = "Sender";
            this.SenderColumnHeader.Width = 120;
            // 
            // TextColumnHeader
            // 
            this.TextColumnHeader.Text = "Text";
            this.TextColumnHeader.Width = 360;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(122, 39);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(254, 21);
            this.comboBox2.TabIndex = 4;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(14, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Formating";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(14, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Subscriber";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(14, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Search";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(122, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(254, 20);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(122, 92);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(124, 20);
            this.dateTimePicker1.TabIndex = 9;
            this.dateTimePicker1.Value = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(252, 92);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(124, 20);
            this.dateTimePicker2.TabIndex = 10;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(14, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "From/To dates";
            // 
            // checkBoxOrLogic
            // 
            this.checkBoxOrLogic.AutoSize = true;
            this.checkBoxOrLogic.Checked = true;
            this.checkBoxOrLogic.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxOrLogic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxOrLogic.Location = new System.Drawing.Point(392, 12);
            this.checkBoxOrLogic.Name = "checkBoxOrLogic";
            this.checkBoxOrLogic.Size = new System.Drawing.Size(196, 20);
            this.checkBoxOrLogic.TabIndex = 12;
            this.checkBoxOrLogic.Text = "Use OR for filtration methods";
            this.checkBoxOrLogic.UseVisualStyleBackColor = true;
            this.checkBoxOrLogic.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBoxAndLogic
            // 
            this.checkBoxAndLogic.AutoSize = true;
            this.checkBoxAndLogic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAndLogic.Location = new System.Drawing.Point(392, 38);
            this.checkBoxAndLogic.Name = "checkBoxAndLogic";
            this.checkBoxAndLogic.Size = new System.Drawing.Size(205, 20);
            this.checkBoxAndLogic.TabIndex = 13;
            this.checkBoxAndLogic.Text = "Use AND for filtration methods";
            this.checkBoxAndLogic.UseVisualStyleBackColor = true;
            this.checkBoxAndLogic.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // storageLogTextBox
            // 
            this.storageLogTextBox.Location = new System.Drawing.Point(12, 457);
            this.storageLogTextBox.Name = "storageLogTextBox";
            this.storageLogTextBox.Size = new System.Drawing.Size(587, 20);
            this.storageLogTextBox.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(14, 437);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Storage log:";
            // 
            // progressBarCharge
            // 
            this.progressBarCharge.Location = new System.Drawing.Point(122, 129);
            this.progressBarCharge.Name = "progressBarCharge";
            this.progressBarCharge.Size = new System.Drawing.Size(254, 19);
            this.progressBarCharge.Step = 1;
            this.progressBarCharge.TabIndex = 17;
            this.progressBarCharge.Value = 100;
            // 
            // checkBoxMessages
            // 
            this.checkBoxMessages.AutoSize = true;
            this.checkBoxMessages.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxMessages.Location = new System.Drawing.Point(392, 89);
            this.checkBoxMessages.Name = "checkBoxMessages";
            this.checkBoxMessages.Size = new System.Drawing.Size(145, 20);
            this.checkBoxMessages.TabIndex = 18;
            this.checkBoxMessages.Text = "Receive messages";
            this.checkBoxMessages.UseVisualStyleBackColor = true;
            this.checkBoxMessages.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // checkBoxCharge
            // 
            this.checkBoxCharge.AutoSize = true;
            this.checkBoxCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCharge.Location = new System.Drawing.Point(392, 128);
            this.checkBoxCharge.Name = "checkBoxCharge";
            this.checkBoxCharge.Size = new System.Drawing.Size(71, 20);
            this.checkBoxCharge.TabIndex = 19;
            this.checkBoxCharge.Text = "Charge";
            this.checkBoxCharge.UseVisualStyleBackColor = true;
            //this.checkBoxCharge.CheckedChanged += new System.EventHandler(this.checkBoxCharge_CheckedChanged);
            // 
            // SMSReceiverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 489);
            this.Controls.Add(this.checkBoxCharge);
            this.Controls.Add(this.checkBoxMessages);
            this.Controls.Add(this.progressBarCharge);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.storageLogTextBox);
            this.Controls.Add(this.checkBoxAndLogic);
            this.Controls.Add(this.checkBoxOrLogic);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.MessageListView);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "SMSReceiverForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListView MessageListView;
        private System.Windows.Forms.ColumnHeader SenderColumnHeader;
        private System.Windows.Forms.ColumnHeader TextColumnHeader;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxOrLogic;
        private System.Windows.Forms.CheckBox checkBoxAndLogic;
        private System.Windows.Forms.TextBox storageLogTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar progressBarCharge;
        private System.Windows.Forms.CheckBox checkBoxMessages;
        private System.Windows.Forms.CheckBox checkBoxCharge;
    }
}

