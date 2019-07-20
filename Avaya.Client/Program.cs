using Sharp.Xmpp;
using Sharp.Xmpp.Client;
using Sharp.Xmpp.Im;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Avaya.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var host = "http://localhost:4200";
            var user = "user1";
            var pass = "user1";

            XmppClient m_xmppClient = new XmppClient(host, user, pass);
            Jid to = new Jid("jid");

            m_xmppClient.Connect();
            Console.WriteLine(m_xmppClient.Jid);
            m_xmppClient.SendMessage(to, "body", "s", "t", MessageType.Chat, null);
            IList<Jid> mucs = m_xmppClient.GetMucServices();
            //m_xmppClient.JoinRoom(mucs.FirstOrDefault(), "chat-room");
            m_xmppClient.SendMessage(mucs.FirstOrDefault(), "body", "s", "t", MessageType.Groupchat, null);
            m_xmppClient.Message += (s, e) => Console.WriteLine(e.Message.Body);

            Console.ReadKey();






        }
    }
}
