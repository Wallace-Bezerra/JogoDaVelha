namespace JogoDaVelha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            Metodo();
            
            
        }
        // declarar array teste*

        int[,] buttons = new int[3, 3];

        int Total = 0;



        //valor incial do x
        int player = 1;

        // Evento de clicar nos botões
        private void ClicarBotao_Click(object sender, EventArgs e)
        {
           Button botao = (Button)sender;
            if (botao.Text == "")
            {
                

                if (player == 1)
                {
                    botao.Text = "X";
                    
                    Metodo();
                    VerificarLinhaColuna();
                    VerificarDiagonal();
                    AlternarJogador();
                }
                else if (player == -1)
                {
                    botao.Text = "O";
                    
                    Metodo();
                    VerificarLinhaColuna();
                    VerificarDiagonal();
                    AlternarJogador();
                }

                VerificarEmpate();

            }
            
                
        }

        // alterar jogadores 
        void AlternarJogador()
        {
            
            
            if (player == 1)
            {
                TextGame.Text = "Jogador O:";
                player = -1;
            }
            else if (player == -1)
            {
                TextGame.Text = "Jogador X:";
                player = 1;
            }
        }


        void VerificarLinhaColuna()
        {
            for (int l = 0; l < 3; l++)
            {
                int soma = 0;
                int soma2 = 0;
                for (int c = 0; c < 3; c++)
                {
                    soma = soma + buttons[l, c];
                    soma2 = soma2 + buttons[c, l];
                }
                if(soma == 3 || soma2 == 3)
                {
                    Message message = new Message("Jogador X venceu!!!");
                    message.ShowDialog();
                    //MessageBox.Show("Jogador X venceu!!!");
                    NovoJogo();
                    return;
                }
                else if(soma == -3 || soma2 == -3)
                {
                    Message message = new Message("Jogador O venceu!!!");
                    message.ShowDialog();
                    //MessageBox.Show("Jogador O venceu!!!");
                    NovoJogo();
                    return;
                }
                
            }
        }
        void VerificarDiagonal()
        {
            int d1 = buttons[0, 0] + buttons[1,1] + buttons[2,2];
            int d2 = buttons[2, 0] + buttons[1, 1] + buttons[0, 2];

            if(d1 == 3 || d2 == 3)
            {
                Message message = new Message("Jogador X venceu!!!");
                message.ShowDialog();
                //MessageBox.Show("Jogador X venceu!!!");
                NovoJogo();
                return;
            }
            else if(d1 == -3 || d2 == -3)
            {
                Message message = new Message("Jogador O venceu!!!");
                message.ShowDialog();
                //MessageBox.Show("Jogador O venceu!!!");
                NovoJogo();
                return;
            }
        }

        void NovoJogo()
        {
            if (MessageBox.Show("Fim de jogo, Parabéns", "Fim de Jogo", MessageBoxButtons.OK) == DialogResult.OK)
            {
                foreach (var item in this.Controls)
                {
                    if (item is Button)
                    {
                        (item as Button).Text = "";
                    }
                }
                Total = 0;
                Array.Clear(buttons);
            }
        }


        // teste de array na tela
        private void buttonTeste_Click(object sender, EventArgs e)
        {
            mostrarArray();
        }

        void mostrarArray()
        {
            foreach (var item in buttons)
            {
                MessageBox.Show(item.ToString()); 
            }
        }
            

        void Metodo()
        {
            if (button1.Text == "X")
            {
                buttons[0, 0] = 1;
            }
            else if (button1.Text == "O")
            {
                buttons[0, 0] = -1;
            }

            if (button2.Text == "X")
            {
                buttons[0, 1] = 1;
            }
            else if (button2.Text == "O")
            {
                buttons[0, 1] = -1;
            }

            if (button3.Text == "X")
            {
                buttons[0, 2] = 1;
            }
            else if (button3.Text == "O")
            {
                buttons[0, 2] = -1;
            }

            if (button4.Text == "X")
            {
                buttons[1, 0] = 1;
            }
            else if (button4.Text == "O")
            {
                buttons[1, 0] = -1;
            }

            if (button5.Text == "X")
            {
                buttons[1, 1] = 1;
            }
            else if (button5.Text == "O")
            {
                buttons[1, 1] = -1;
            }

            if (button6.Text == "X")
            {
                buttons[1, 2] = 1;
            }
            else if (button6.Text == "O")
            {
                buttons[1, 2] = -1;
            }


            if (button7.Text == "X")
            {
                buttons[2, 0] = 1;
            }
            else if (button7.Text == "O")
            {
                buttons[2, 0] = -1;
            }

            if (button8.Text == "X")
            {
                buttons[2, 1] = 1;
            }
            else if (button8.Text == "O")
            {
                buttons[2, 1] = -1;
            }

            if (button9.Text == "X")
            {
                buttons[2, 2] = 1;
            }
            else if (button9.Text == "O")
            {
                buttons[2, 2] = -1;
            }
            
        }

        void VerificarEmpate()
        {
            Total = 0;
            for (int l = 0; l < 3; l++)
            {
                for (int c = 0; c < 3; c++)
                {
                    if (buttons[l,c] == 1 || buttons[l,c] == -1)
                    {
                        Total++;
                    }
                }
            }

            if(Total == 9)
            {
                
                Message message = new Message("Empate!!!");
                message.ShowDialog();
                NovoJogo();
            }
        }
    }
}