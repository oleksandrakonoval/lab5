using System;
using System.Collections.Generic;

namespace SimCorp.IMS.Messages
{
    public class MyMessage
    {
        public string User { get; set; }

        public string Text { get; set; }

        public DateTime ReceivingTime { get; set; }

       
        public MyMessage() {
            List<string> users = new List<string>();
            users.Add("+380671234567");
            users.Add("+380939873546");
            users.Add("+380997364527");
            users.Add("+380731786546");

            //Random rndTime = new Random();
            //ReceivingTime = DateTime.Now.AddHours(rndTime.Next(-100,100));

            ReceivingTime = DateTime.Now;

            Random rndUser = new Random();
            User = users[rndUser.Next(0,users.Count)];

            Random rndTxt = new Random();
            char[] symbols ={' ',' ',' ',' ',' ','a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
            int length = rndTxt.Next(1,symbols.Length);
            for (int i =0; i < length; i++) {
                Text += symbols[rndTxt.Next(0,26)];
            }
        }

        public override string ToString() {
            return $"From {this.User}:{Environment.NewLine}{this.Text} {Environment.NewLine}Received at: [{this.ReceivingTime}] {Environment.NewLine}";
        }
    }
}
