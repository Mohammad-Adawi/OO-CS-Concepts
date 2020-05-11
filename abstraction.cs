using System;

namespace abstraction{
       class Program{
        abstract class SecretMessage{
            public void mySecretMessage(){
                Console.WriteLine("This is my secret message!");
            }
        }
        class PublicMessage : SecretMessage {

            public void myPublicMessage(){
            Console.WriteLine("Everyone can see this message!");
        }
        }
        static void Main(string[] args){
           PublicMessage mypubMsg = new PublicMessage();
           mypubMsg.myPublicMessage();
            mypubMsg.mySecretMessage();
        }
    }
}