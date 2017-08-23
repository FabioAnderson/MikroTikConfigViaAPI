using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net.Sockets;


namespace mkt
{
    class Program
    {

        public static void ler(MK radio)
        {
            foreach (String h in radio.Read())
            {

                int i = h.Length;

                Console.WriteLine("\n" + h);
            }
        }

        static void Main(string[] args)
        {


            MK mikrotik = new MK("192.168.88.1");
            if (!mikrotik.Login("admin", ""))
            {
                Console.WriteLine("Falha ao realizar Login");
                mikrotik.Close();
                return;
            }

            /*
            mikrotik.Send("/interface/print");
            mikrotik.Send(".tag=tent1", true);
            */
            /*
            //Criando a Bridge Wlan e Porta 3
            mikrotik.Send("/interface/bridge/add");
            mikrotik.Send("=fast-forward=no");
            mikrotik.Send("=name=bridge wlan e porta 3");
            mikrotik.Send(".tag=CriarBridgeWlan", true);
            
            ler(mikrotik);

            //Criando a Bridge-Local
            mikrotik.Send("/interface/bridge/add");
            mikrotik.Send("=admin-mac=D4:CA:6D:C8:C0:AB");
            mikrotik.Send("=auto-mac=no");
            mikrotik.Send("=fast-forward=no");
            mikrotik.Send("=mtu=1500");
            mikrotik.Send("=name=bridge-local");
            mikrotik.Send(".tag=CriarBridge-Local", true);
            
            ler(mikrotik);

            //Nomeando as portas e a Wlan
            mikrotik.Send("/interface/ethernet/set");
            mikrotik.Send("=.id=ether1");
            mikrotik.Send("=mac-address=D4:CA:6D:C8:C0:AA");
            mikrotik.Send("=name=ether1-gateway");
            mikrotik.Send(".tag=AlterarEther1", true);

            ler(mikrotik);

            mikrotik.Send("/interface/ethernet/set");
            mikrotik.Send("=.id=ether2");
            mikrotik.Send("=mac-address=D4:CA:6D:C8:C0:AB");
            mikrotik.Send("=name=ether2-master-local");
            mikrotik.Send(".tag=AlterarEther2", true);

            ler(mikrotik);

            mikrotik.Send("/interface/ethernet/set");
            mikrotik.Send("=.id=ether3");
            mikrotik.Send("=mac-address=D4:CA:6D:C8:C0:AC");
            mikrotik.Send("=name=ether3-master-local");
            mikrotik.Send(".tag=AlterarEther3", true);

            ler(mikrotik);

            mikrotik.Send("/interface/ethernet/set");
            mikrotik.Send("=.id=ether4");
            mikrotik.Send("=mac-address=D4:CA:6D:C8:C0:AD");
            mikrotik.Send("=name=ether4-master-local");
            mikrotik.Send(".tag=AlterarEther4", true);

            ler(mikrotik);

            mikrotik.Send("/interface/ethernet/set");
            mikrotik.Send("=.id=ether5");
            mikrotik.Send("=mac-address=D4:CA:6D:C8:C0:AE");
            mikrotik.Send("=name=ether5-master-local");
            mikrotik.Send(".tag=AlterarEther5", true);

            ler(mikrotik);
            
            mikrotik.Send("/interface/wireless/set");
            mikrotik.Send("=.id=wlan1");
            mikrotik.Send("=default-forwarding=no");
            mikrotik.Send("=disabled=no");
            mikrotik.Send("=frequency=2437");
            mikrotik.Send("=mode=ap-bridge");
            mikrotik.Send("=ssid=Polishop WiFi");
            mikrotik.Send(".tag=AlterarWlan1", true);

            ler(mikrotik);
            */
            //ip neighbor discovery
            //set ether1-gateway discover = no
            mikrotik.Send("/interface/wireless/set");
            mikrotik.Send("=.id=wlan1");
            mikrotik.Send("=default-forwarding=no");
            mikrotik.Send("=disabled=no");
            mikrotik.Send("=frequency=2437");
            mikrotik.Send("=mode=ap-bridge");
            mikrotik.Send("=ssid=Polishop WiFi");
            mikrotik.Send(".tag=AlterarWlan1", true);

            Console.ReadKey();


        }

    }
}
