using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MsgPraVoce
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        void Msgs(object sender, EventArgs e)
        {
            Random random = new Random();
            string[] msgs =
            {"A persistência é o caminho do êxito",
            "Só existe um êxito: a capacidade de levar a vida que se quer.",
            "A coragem não é ausência do medo; é a persistência apesar do medo.",
            "Só se pode alcançar um grande êxito quando nos mantemos fiéis a nós mesmos.",
            "Creia em si, mas não duvide sempre dos outros."
        };


            mensagem.Text = msgs[random.Next(0, msgs.Length- 1)];
        }
    }
}
