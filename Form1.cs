using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sorteador12numeros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Cria um array com 12 posições para armazenar as cartas que serão sorteadas   
        int[] carta = new int[12];

        // Variável que indica se tem ou não carta repedita
        bool temCartaRepedita = false;

        // Variáveis que controlam a jogada da banca
        int pontosBanca = 0;
        int quantCartasBanca = 2;

        // Variáveis que controlam a jogada do jogador.
        int pontosJogador = 0;
        int quantCartasJogador = 2;

        // Cria um array com 12 posições para armazenar valor das cartas
        int[] valorCarta = new int[12];

        // Variaveis para calcular o placar geral
        int placarBanca = 0;
        int placarJogador = 0;
       

               
        private void btnInicar_Click(object sender, EventArgs e)
        {
            // Ao clicar no botao Iniciar, começa todo o processo para sortear as cartas e ver se há cartas repetidas.
            carta[0] = new Random().Next(1, 53);
            lbl0.Text = carta[0].ToString();
            timerCarta1.Enabled = true;
            barraProgresso.Visible = true;
            barraProgresso.Value = 10;
            
            
        }

        private void timerCarta1_Tick(object sender, EventArgs e)
        {
            carta[1] = new Random().Next(1, 53);
            lbl1.Text = carta[1].ToString();
            timerCarta1.Enabled = false;
            timerCarta2.Enabled = true;
            barraProgresso.Value = 20;
        }

        private void timerCarta2_Tick(object sender, EventArgs e)
        {
            carta[2] = new Random().Next(1, 53);
            lbl2.Text = carta[2].ToString();
            timerCarta2.Enabled = false;
            timerCarta3.Enabled = true;
            barraProgresso.Value = 30;
        }

        private void timerCarta3_Tick(object sender, EventArgs e)
        {
            carta[3] = new Random().Next(1, 53);
            lbl3.Text = carta[3].ToString();
            timerCarta3.Enabled = false;
            timerCarta4.Enabled = true;
            barraProgresso.Value = 40;
        }

        private void timerCarta4_Tick(object sender, EventArgs e)
        {
            carta[4] = new Random().Next(1, 53);
            lbl4.Text = carta[4].ToString();
            timerCarta4.Enabled = false;
            timerCarta5.Enabled = true;
            barraProgresso.Value = 50;
        }

        private void timerCarta5_Tick(object sender, EventArgs e)
        {
            carta[5] = new Random().Next(1, 53);
            lbl5.Text = carta[5].ToString();
            timerCarta5.Enabled = false;
            timerCarta6.Enabled = true;
            barraProgresso.Value = 60;
            
        }

        private void timerCarta6_Tick(object sender, EventArgs e)
        {
            carta[6] = new Random().Next(1, 53);
            lbl6.Text = carta[6].ToString();
            timerCarta6.Enabled = false;
            timerCarta7.Enabled = true;
            barraProgresso.Value = 65;
        }

        private void timerCarta7_Tick(object sender, EventArgs e)
        {
            carta[7] = new Random().Next(1, 53);
            lbl7.Text = carta[7].ToString();
            timerCarta7.Enabled = false;
            timerCarta8.Enabled = true;
            barraProgresso.Value = 70;
        }

        private void timerCarta8_Tick(object sender, EventArgs e)
        {
            carta[8] = new Random().Next(1, 53);
            lbl8.Text = carta[8].ToString();
            timerCarta8.Enabled = false;
            timerCarta9.Enabled = true;
            barraProgresso.Value = 80;
        }

        private void timerCarta9_Tick(object sender, EventArgs e)
        {
            carta[9] = new Random().Next(1, 53);
            lbl9.Text = carta[9].ToString();
            timerCarta9.Enabled = false;
            timerCarta10.Enabled = true;
            barraProgresso.Value = 85;
        }

        private void timerCarta10_Tick(object sender, EventArgs e)
        {
            carta[10] = new Random().Next(1, 53);
            lbl10.Text = carta[10].ToString();
            timerCarta10.Enabled = false;
            timerCarta11.Enabled = true;
            barraProgresso.Value = 90;
        }

        private void timerCarta11_Tick(object sender, EventArgs e)
        {
            carta[11] = new Random().Next(1, 53);
            lbl11.Text = carta[11].ToString();
            timerCarta11.Enabled = false;
            timerVerificacao.Enabled = true;
        }

        private void compararSeTemCartasRepetidas()
        {
            // Vai verificar se há cartas repetidas entre as sorteadas.
            if (carta[0] == carta[1])
                temCartaRepedita = true;

            else if (carta[0] == carta[2])
                temCartaRepedita = true;

            else if (carta[0] == carta[3])
                temCartaRepedita = true;

            else if (carta[0] == carta[4])
                temCartaRepedita = true;

            else if (carta[0] == carta[5])
                temCartaRepedita = true;

            else if (carta[0] == carta[6])
                temCartaRepedita = true;

            else if (carta[0] == carta[7])
                temCartaRepedita = true;

            else if (carta[0] == carta[8])
                temCartaRepedita = true;

            else if (carta[0] == carta[9])
                temCartaRepedita = true;

            else if (carta[0] == carta[10])
                temCartaRepedita = true;

            else if (carta[0] == carta[11])
                temCartaRepedita = true;

            else if (carta[1] == carta[2])
                temCartaRepedita = true;

            else if (carta[1] == carta[3])
                temCartaRepedita = true;

            else if (carta[1] == carta[4])
                temCartaRepedita = true;

            else if (carta[1] == carta[5])
                temCartaRepedita = true;

            else if (carta[1] == carta[6])
                temCartaRepedita = true;

            else if (carta[1] == carta[7])
                temCartaRepedita = true;

            else if (carta[1] == carta[8])
                temCartaRepedita = true;

            else if (carta[1] == carta[9])
                temCartaRepedita = true;

            else if (carta[1] == carta[10])
                temCartaRepedita = true;

            else if (carta[1] == carta[11])
                temCartaRepedita = true;

            else if (carta[2] == carta[3])
                temCartaRepedita = true;

            else if (carta[2] == carta[4])
                temCartaRepedita = true;

            else if (carta[2] == carta[5])
                temCartaRepedita = true;

            else if (carta[2] == carta[6])
                temCartaRepedita = true;

            else if (carta[2] == carta[7])
                temCartaRepedita = true;

            else if (carta[2] == carta[8])
                temCartaRepedita = true;

            else if (carta[2] == carta[9])
                temCartaRepedita = true;

            else if (carta[2] == carta[10])
                temCartaRepedita = true;

            else if (carta[2] == carta[11])
                temCartaRepedita = true;

            else if (carta[3] == carta[4])
                temCartaRepedita = true;

            else if (carta[3] == carta[5])
                temCartaRepedita = true;

            else if (carta[3] == carta[6])
                temCartaRepedita = true;

            else if (carta[3] == carta[7])
                temCartaRepedita = true;

            else if (carta[3] == carta[8])
                temCartaRepedita = true;

            else if (carta[3] == carta[9])
                temCartaRepedita = true;

            else if (carta[3] == carta[10])
                temCartaRepedita = true;

            else if (carta[3] == carta[11])
                temCartaRepedita = true;

            else if (carta[4] == carta[5])
                temCartaRepedita = true;

            else if (carta[4] == carta[6])
                temCartaRepedita = true;

            else if (carta[4] == carta[7])
                temCartaRepedita = true;

            else if (carta[4] == carta[8])
                temCartaRepedita = true;

            else if (carta[4] == carta[9])
                temCartaRepedita = true;

            else if (carta[4] == carta[10])
                temCartaRepedita = true;

            else if (carta[4] == carta[11])
                temCartaRepedita = true;

            else if (carta[5] == carta[6])
                temCartaRepedita = true;

            else if (carta[5] == carta[7])
                temCartaRepedita = true;

            else if (carta[5] == carta[8])
                temCartaRepedita = true;

            else if (carta[5] == carta[9])
                temCartaRepedita = true;

            else if (carta[5] == carta[10])
                temCartaRepedita = true;

            else if (carta[5] == carta[11])
                temCartaRepedita = true;

            else if (carta[6] == carta[7])
                temCartaRepedita = true;

            else if (carta[6] == carta[8])
                temCartaRepedita = true;

            else if (carta[6] == carta[9])
                temCartaRepedita = true;

            else if (carta[6] == carta[10])
                temCartaRepedita = true;

            else if (carta[6] == carta[11])
                temCartaRepedita = true;

            else if (carta[7] == carta[8])
                temCartaRepedita = true;

            else if (carta[7] == carta[9])
                temCartaRepedita = true;

            else if (carta[7] == carta[10])
                temCartaRepedita = true;

            else if (carta[7] == carta[11])
                temCartaRepedita = true;

            else if (carta[8] == carta[9])
                temCartaRepedita = true;

            else if (carta[8] == carta[10])
                temCartaRepedita = true;

            else if (carta[8] == carta[11])
                temCartaRepedita = true;

            else if (carta[9] == carta[10])
                temCartaRepedita = true;

            else if (carta[9] == carta[11])
                temCartaRepedita = true;

            else if (carta[10] == carta[11])
                temCartaRepedita = true;
        }

        private void timerVerificacao_Tick(object sender, EventArgs e)
        {
            compararSeTemCartasRepetidas();
            if (temCartaRepedita)
            {
                temCartaRepedita = false;
                lblCartaRepetida.Text = "CARTA REPETIDA";
                timerVerificacao.Enabled = false;
                btnInicar.PerformClick();
            }
            else
            {
                // Ações gerais da condição
                lblCartaRepetida.Text = "SEM REPETIÇÃO";
                timerVerificacao.Enabled = false;
                btnInicar.Visible = false;
                barraProgresso.Visible = false;
                lblFundo.Visible = false;
                

                // Ações das cartas da banca
                distribuirCarta0();
                atribuirValorCarta0();
                pontosBanca = valorCarta[0];
                lblPontosBanca.Text = "Pontos banca: " + pontosBanca.ToString();
                lblPontosBanca.Visible = true;

                // Ações das cartas do jogador
                distribuirCarta6();
                distribuirCarta7();                
                atribuirValorCarta6();
                atribuirValorCarta7();
                pontosJogador = valorCarta[6] + valorCarta[7];
                lblPontosJogador.Text = "Pontos Jogador: " + pontosJogador.ToString();
                lblPontosJogador.Visible = true;

                if (pontosJogador < 21)
                {
                    btnMaisCarta1.Visible = true;
                    btnOK.Visible = true;
                }
                else
                    btnBlackJack.Visible = true;
            }
        }

        private void distribuirCarta0()
        {
            pct0.Visible = true;
            int index0 = 0;
            if (carta[index0] == 1)
                pct0.Image = global::Sorteador12numeros.Properties.Resources._1;

            else if (carta[index0] == 2)
                pct0.Image = global::Sorteador12numeros.Properties.Resources._2;

            else if (carta[index0] == 3)
                pct0.Image = global::Sorteador12numeros.Properties.Resources._3;

            else if (carta[index0] == 4)
                pct0.Image = global::Sorteador12numeros.Properties.Resources._4;

            else if (carta[index0] == 5)
                pct0.Image = global::Sorteador12numeros.Properties.Resources._5;

            else if (carta[index0] == 6)
                pct0.Image = global::Sorteador12numeros.Properties.Resources._6;

            else if (carta[index0] == 7)
                pct0.Image = global::Sorteador12numeros.Properties.Resources._7;

            else if (carta[index0] == 8)
                pct0.Image = global::Sorteador12numeros.Properties.Resources._8;

            else if (carta[index0] == 9)
                pct0.Image = global::Sorteador12numeros.Properties.Resources._9;

            else if (carta[index0] == 10)
                pct0.Image = global::Sorteador12numeros.Properties.Resources._10;

            else if (carta[index0] == 11)
                pct0.Image = global::Sorteador12numeros.Properties.Resources._11;

            else if (carta[index0] == 12)
                pct0.Image = global::Sorteador12numeros.Properties.Resources._12;

            else if (carta[index0] == 13)
                pct0.Image = global::Sorteador12numeros.Properties.Resources._13;

            else if (carta[index0] == 14)
                pct0.Image = global::Sorteador12numeros.Properties.Resources._14;

            else if (carta[index0] == 15)
                pct0.Image = global::Sorteador12numeros.Properties.Resources._15;

            else if (carta[index0] == 16)
                pct0.Image = global::Sorteador12numeros.Properties.Resources._16;

            else if (carta[index0] == 17)
                pct0.Image = global::Sorteador12numeros.Properties.Resources._17;

            else if (carta[index0] == 18)
                pct0.Image = global::Sorteador12numeros.Properties.Resources._18;

            else if (carta[index0] == 19)
                pct0.Image = global::Sorteador12numeros.Properties.Resources._19;

            else if (carta[index0] == 20)
                pct0.Image = global::Sorteador12numeros.Properties.Resources._20;

            else if (carta[index0] == 21)
                pct0.Image = global::Sorteador12numeros.Properties.Resources._21;

            else if (carta[index0] == 22)
                pct0.Image = global::Sorteador12numeros.Properties.Resources._22;

            else if (carta[index0] == 23)
                pct0.Image = global::Sorteador12numeros.Properties.Resources._23;

            else if (carta[index0] == 24)
                pct0.Image = global::Sorteador12numeros.Properties.Resources._24;

            else if (carta[index0] == 25)
                pct0.Image = global::Sorteador12numeros.Properties.Resources._25;

            else if (carta[index0] == 26)
                pct0.Image = global::Sorteador12numeros.Properties.Resources._26;

            else if (carta[index0] == 27)
                pct0.Image = global::Sorteador12numeros.Properties.Resources._27;

            else if (carta[index0] == 28)
                pct0.Image = global::Sorteador12numeros.Properties.Resources._28;

            else if (carta[index0] == 29)
                pct0.Image = global::Sorteador12numeros.Properties.Resources._29;

            else if (carta[index0] == 30)
                pct0.Image = global::Sorteador12numeros.Properties.Resources._30;

            else if (carta[index0] == 31)
                pct0.Image = global::Sorteador12numeros.Properties.Resources._31;

            else if (carta[index0] == 32)
                pct0.Image = global::Sorteador12numeros.Properties.Resources._32;

            else if (carta[index0] == 33)
                pct0.Image = global::Sorteador12numeros.Properties.Resources._33;

            else if (carta[index0] == 34)
                pct0.Image = global::Sorteador12numeros.Properties.Resources._34;

            else if (carta[index0] == 35)
                pct0.Image = global::Sorteador12numeros.Properties.Resources._35;

            else if (carta[index0] == 36)
                pct0.Image = global::Sorteador12numeros.Properties.Resources._36;

            else if (carta[index0] == 37)
                pct0.Image = global::Sorteador12numeros.Properties.Resources._37;

            else if (carta[index0] == 38)
                pct0.Image = global::Sorteador12numeros.Properties.Resources._38;

            else if (carta[index0] == 39)
                pct0.Image = global::Sorteador12numeros.Properties.Resources._39;

            else if (carta[index0] == 40)
                pct0.Image = global::Sorteador12numeros.Properties.Resources._40;

            else if (carta[index0] == 41)
                pct0.Image = global::Sorteador12numeros.Properties.Resources._41;

            else if (carta[index0] == 42)
                pct0.Image = global::Sorteador12numeros.Properties.Resources._42;

            else if (carta[index0] == 43)
                pct0.Image = global::Sorteador12numeros.Properties.Resources._43;

            else if (carta[index0] == 44)
                pct0.Image = global::Sorteador12numeros.Properties.Resources._44;

            else if (carta[index0] == 45)
                pct0.Image = global::Sorteador12numeros.Properties.Resources._45;

            else if (carta[index0] == 46)
                pct0.Image = global::Sorteador12numeros.Properties.Resources._46;

            else if (carta[index0] == 47)
                pct0.Image = global::Sorteador12numeros.Properties.Resources._47;

            else if (carta[index0] == 48)
                pct0.Image = global::Sorteador12numeros.Properties.Resources._48;

            else if (carta[index0] == 49)
                pct0.Image = global::Sorteador12numeros.Properties.Resources._49;

            else if (carta[index0] == 50)
                pct0.Image = global::Sorteador12numeros.Properties.Resources._50;

            else if (carta[index0] == 51)
                pct0.Image = global::Sorteador12numeros.Properties.Resources._51;

            else if (carta[index0] == 52)
                pct0.Image = global::Sorteador12numeros.Properties.Resources._52;
        }
        private void distribuirCarta1()
        {
            pct1.Visible = true;
            int index1 = 1;
            if (carta[index1] == 1)
                pct1.Image = global::Sorteador12numeros.Properties.Resources._1;

            else if (carta[index1] == 2)
                pct1.Image = global::Sorteador12numeros.Properties.Resources._2;

            else if (carta[index1] == 3)
                pct1.Image = global::Sorteador12numeros.Properties.Resources._3;

            else if (carta[index1] == 4)
                pct1.Image = global::Sorteador12numeros.Properties.Resources._4;

            else if (carta[index1] == 5)
                pct1.Image = global::Sorteador12numeros.Properties.Resources._5;

            else if (carta[index1] == 6)
                pct1.Image = global::Sorteador12numeros.Properties.Resources._6;

            else if (carta[index1] == 7)
                pct1.Image = global::Sorteador12numeros.Properties.Resources._7;

            else if (carta[index1] == 8)
                pct1.Image = global::Sorteador12numeros.Properties.Resources._8;

            else if (carta[index1] == 9)
                pct1.Image = global::Sorteador12numeros.Properties.Resources._9;

            else if (carta[index1] == 10)
                pct1.Image = global::Sorteador12numeros.Properties.Resources._10;

            else if (carta[index1] == 11)
                pct1.Image = global::Sorteador12numeros.Properties.Resources._11;

            else if (carta[index1] == 12)
                pct1.Image = global::Sorteador12numeros.Properties.Resources._12;

            else if (carta[index1] == 13)
                pct1.Image = global::Sorteador12numeros.Properties.Resources._13;

            else if (carta[index1] == 14)
                pct1.Image = global::Sorteador12numeros.Properties.Resources._14;

            else if (carta[index1] == 15)
                pct1.Image = global::Sorteador12numeros.Properties.Resources._15;

            else if (carta[index1] == 16)
                pct1.Image = global::Sorteador12numeros.Properties.Resources._16;

            else if (carta[index1] == 17)
                pct1.Image = global::Sorteador12numeros.Properties.Resources._17;

            else if (carta[index1] == 18)
                pct1.Image = global::Sorteador12numeros.Properties.Resources._18;

            else if (carta[index1] == 19)
                pct1.Image = global::Sorteador12numeros.Properties.Resources._19;

            else if (carta[index1] == 20)
                pct1.Image = global::Sorteador12numeros.Properties.Resources._20;

            else if (carta[index1] == 21)
                pct1.Image = global::Sorteador12numeros.Properties.Resources._21;

            else if (carta[index1] == 22)
                pct1.Image = global::Sorteador12numeros.Properties.Resources._22;

            else if (carta[index1] == 23)
                pct1.Image = global::Sorteador12numeros.Properties.Resources._23;

            else if (carta[index1] == 24)
                pct1.Image = global::Sorteador12numeros.Properties.Resources._24;

            else if (carta[index1] == 25)
                pct1.Image = global::Sorteador12numeros.Properties.Resources._25;

            else if (carta[index1] == 26)
                pct1.Image = global::Sorteador12numeros.Properties.Resources._26;

            else if (carta[index1] == 27)
                pct1.Image = global::Sorteador12numeros.Properties.Resources._27;

            else if (carta[index1] == 28)
                pct1.Image = global::Sorteador12numeros.Properties.Resources._28;

            else if (carta[index1] == 29)
                pct1.Image = global::Sorteador12numeros.Properties.Resources._29;

            else if (carta[index1] == 30)
                pct1.Image = global::Sorteador12numeros.Properties.Resources._30;

            else if (carta[index1] == 31)
                pct1.Image = global::Sorteador12numeros.Properties.Resources._31;

            else if (carta[index1] == 32)
                pct1.Image = global::Sorteador12numeros.Properties.Resources._32;

            else if (carta[index1] == 33)
                pct1.Image = global::Sorteador12numeros.Properties.Resources._33;

            else if (carta[index1] == 34)
                pct1.Image = global::Sorteador12numeros.Properties.Resources._34;

            else if (carta[index1] == 35)
                pct1.Image = global::Sorteador12numeros.Properties.Resources._35;

            else if (carta[index1] == 36)
                pct1.Image = global::Sorteador12numeros.Properties.Resources._36;

            else if (carta[index1] == 37)
                pct1.Image = global::Sorteador12numeros.Properties.Resources._37;

            else if (carta[index1] == 38)
                pct1.Image = global::Sorteador12numeros.Properties.Resources._38;

            else if (carta[index1] == 39)
                pct1.Image = global::Sorteador12numeros.Properties.Resources._39;

            else if (carta[index1] == 40)
                pct1.Image = global::Sorteador12numeros.Properties.Resources._40;

            else if (carta[index1] == 41)
                pct1.Image = global::Sorteador12numeros.Properties.Resources._41;

            else if (carta[index1] == 42)
                pct1.Image = global::Sorteador12numeros.Properties.Resources._42;

            else if (carta[index1] == 43)
                pct1.Image = global::Sorteador12numeros.Properties.Resources._43;

            else if (carta[index1] == 44)
                pct1.Image = global::Sorteador12numeros.Properties.Resources._44;

            else if (carta[index1] == 45)
                pct1.Image = global::Sorteador12numeros.Properties.Resources._45;

            else if (carta[index1] == 46)
                pct1.Image = global::Sorteador12numeros.Properties.Resources._46;

            else if (carta[index1] == 47)
                pct1.Image = global::Sorteador12numeros.Properties.Resources._47;

            else if (carta[index1] == 48)
                pct1.Image = global::Sorteador12numeros.Properties.Resources._48;

            else if (carta[index1] == 49)
                pct1.Image = global::Sorteador12numeros.Properties.Resources._49;

            else if (carta[index1] == 50)
                pct1.Image = global::Sorteador12numeros.Properties.Resources._50;

            else if (carta[index1] == 51)
                pct1.Image = global::Sorteador12numeros.Properties.Resources._51;

            else if (carta[index1] == 52)
                pct1.Image = global::Sorteador12numeros.Properties.Resources._52;
        }
        private void distribuirCarta2()
        {
            pct2.Visible = true;
            int index2 = 2;
            if (carta[index2] == 1)
                pct2.Image = global::Sorteador12numeros.Properties.Resources._1;

            else if (carta[index2] == 2)
                pct2.Image = global::Sorteador12numeros.Properties.Resources._2;

            else if (carta[index2] == 3)
                pct2.Image = global::Sorteador12numeros.Properties.Resources._3;

            else if (carta[index2] == 4)
                pct2.Image = global::Sorteador12numeros.Properties.Resources._4;

            else if (carta[index2] == 5)
                pct2.Image = global::Sorteador12numeros.Properties.Resources._5;

            else if (carta[index2] == 6)
                pct2.Image = global::Sorteador12numeros.Properties.Resources._6;

            else if (carta[index2] == 7)
                pct2.Image = global::Sorteador12numeros.Properties.Resources._7;

            else if (carta[index2] == 8)
                pct2.Image = global::Sorteador12numeros.Properties.Resources._8;

            else if (carta[index2] == 9)
                pct2.Image = global::Sorteador12numeros.Properties.Resources._9;

            else if (carta[index2] == 10)
                pct2.Image = global::Sorteador12numeros.Properties.Resources._10;

            else if (carta[index2] == 11)
                pct2.Image = global::Sorteador12numeros.Properties.Resources._11;

            else if (carta[index2] == 12)
                pct2.Image = global::Sorteador12numeros.Properties.Resources._12;

            else if (carta[index2] == 13)
                pct2.Image = global::Sorteador12numeros.Properties.Resources._13;

            else if (carta[index2] == 14)
                pct2.Image = global::Sorteador12numeros.Properties.Resources._14;

            else if (carta[index2] == 15)
                pct2.Image = global::Sorteador12numeros.Properties.Resources._15;

            else if (carta[index2] == 16)
                pct2.Image = global::Sorteador12numeros.Properties.Resources._16;

            else if (carta[index2] == 17)
                pct2.Image = global::Sorteador12numeros.Properties.Resources._17;

            else if (carta[index2] == 18)
                pct2.Image = global::Sorteador12numeros.Properties.Resources._18;

            else if (carta[index2] == 19)
                pct2.Image = global::Sorteador12numeros.Properties.Resources._19;

            else if (carta[index2] == 20)
                pct2.Image = global::Sorteador12numeros.Properties.Resources._20;

            else if (carta[index2] == 21)
                pct2.Image = global::Sorteador12numeros.Properties.Resources._21;

            else if (carta[index2] == 22)
                pct2.Image = global::Sorteador12numeros.Properties.Resources._22;

            else if (carta[index2] == 23)
                pct2.Image = global::Sorteador12numeros.Properties.Resources._23;

            else if (carta[index2] == 24)
                pct2.Image = global::Sorteador12numeros.Properties.Resources._24;

            else if (carta[index2] == 25)
                pct2.Image = global::Sorteador12numeros.Properties.Resources._25;

            else if (carta[index2] == 26)
                pct2.Image = global::Sorteador12numeros.Properties.Resources._26;

            else if (carta[index2] == 27)
                pct2.Image = global::Sorteador12numeros.Properties.Resources._27;

            else if (carta[index2] == 28)
                pct2.Image = global::Sorteador12numeros.Properties.Resources._28;

            else if (carta[index2] == 29)
                pct2.Image = global::Sorteador12numeros.Properties.Resources._29;

            else if (carta[index2] == 30)
                pct2.Image = global::Sorteador12numeros.Properties.Resources._30;

            else if (carta[index2] == 31)
                pct2.Image = global::Sorteador12numeros.Properties.Resources._31;

            else if (carta[index2] == 32)
                pct2.Image = global::Sorteador12numeros.Properties.Resources._32;

            else if (carta[index2] == 33)
                pct2.Image = global::Sorteador12numeros.Properties.Resources._33;

            else if (carta[index2] == 34)
                pct2.Image = global::Sorteador12numeros.Properties.Resources._34;

            else if (carta[index2] == 35)
                pct2.Image = global::Sorteador12numeros.Properties.Resources._35;

            else if (carta[index2] == 36)
                pct2.Image = global::Sorteador12numeros.Properties.Resources._36;

            else if (carta[index2] == 37)
                pct2.Image = global::Sorteador12numeros.Properties.Resources._37;

            else if (carta[index2] == 38)
                pct2.Image = global::Sorteador12numeros.Properties.Resources._38;

            else if (carta[index2] == 39)
                pct2.Image = global::Sorteador12numeros.Properties.Resources._39;

            else if (carta[index2] == 40)
                pct2.Image = global::Sorteador12numeros.Properties.Resources._40;

            else if (carta[index2] == 41)
                pct2.Image = global::Sorteador12numeros.Properties.Resources._41;

            else if (carta[index2] == 42)
                pct2.Image = global::Sorteador12numeros.Properties.Resources._42;

            else if (carta[index2] == 43)
                pct2.Image = global::Sorteador12numeros.Properties.Resources._43;

            else if (carta[index2] == 44)
                pct2.Image = global::Sorteador12numeros.Properties.Resources._44;

            else if (carta[index2] == 45)
                pct2.Image = global::Sorteador12numeros.Properties.Resources._45;

            else if (carta[index2] == 46)
                pct2.Image = global::Sorteador12numeros.Properties.Resources._46;

            else if (carta[index2] == 47)
                pct2.Image = global::Sorteador12numeros.Properties.Resources._47;

            else if (carta[index2] == 48)
                pct2.Image = global::Sorteador12numeros.Properties.Resources._48;

            else if (carta[index2] == 49)
                pct2.Image = global::Sorteador12numeros.Properties.Resources._49;

            else if (carta[index2] == 50)
                pct2.Image = global::Sorteador12numeros.Properties.Resources._50;

            else if (carta[index2] == 51)
                pct2.Image = global::Sorteador12numeros.Properties.Resources._51;

            else if (carta[index2] == 52)
                pct2.Image = global::Sorteador12numeros.Properties.Resources._52;
        }
        private void distribuirCarta3()
        {
            pct3.Visible = true;
            int index3 = 3;
            if (carta[index3] == 1)
                pct3.Image = global::Sorteador12numeros.Properties.Resources._1;

            else if (carta[index3] == 2)
                pct3.Image = global::Sorteador12numeros.Properties.Resources._2;

            else if (carta[index3] == 3)
                pct3.Image = global::Sorteador12numeros.Properties.Resources._3;

            else if (carta[index3] == 4)
                pct3.Image = global::Sorteador12numeros.Properties.Resources._4;

            else if (carta[index3] == 5)
                pct3.Image = global::Sorteador12numeros.Properties.Resources._5;

            else if (carta[index3] == 6)
                pct3.Image = global::Sorteador12numeros.Properties.Resources._6;

            else if (carta[index3] == 7)
                pct3.Image = global::Sorteador12numeros.Properties.Resources._7;

            else if (carta[index3] == 8)
                pct3.Image = global::Sorteador12numeros.Properties.Resources._8;

            else if (carta[index3] == 9)
                pct3.Image = global::Sorteador12numeros.Properties.Resources._9;

            else if (carta[index3] == 10)
                pct3.Image = global::Sorteador12numeros.Properties.Resources._10;

            else if (carta[index3] == 11)
                pct3.Image = global::Sorteador12numeros.Properties.Resources._11;

            else if (carta[index3] == 12)
                pct3.Image = global::Sorteador12numeros.Properties.Resources._12;

            else if (carta[index3] == 13)
                pct3.Image = global::Sorteador12numeros.Properties.Resources._13;

            else if (carta[index3] == 14)
                pct3.Image = global::Sorteador12numeros.Properties.Resources._14;

            else if (carta[index3] == 15)
                pct3.Image = global::Sorteador12numeros.Properties.Resources._15;

            else if (carta[index3] == 16)
                pct3.Image = global::Sorteador12numeros.Properties.Resources._16;

            else if (carta[index3] == 17)
                pct3.Image = global::Sorteador12numeros.Properties.Resources._17;

            else if (carta[index3] == 18)
                pct3.Image = global::Sorteador12numeros.Properties.Resources._18;

            else if (carta[index3] == 19)
                pct3.Image = global::Sorteador12numeros.Properties.Resources._19;

            else if (carta[index3] == 20)
                pct3.Image = global::Sorteador12numeros.Properties.Resources._20;

            else if (carta[index3] == 21)
                pct3.Image = global::Sorteador12numeros.Properties.Resources._21;

            else if (carta[index3] == 22)
                pct3.Image = global::Sorteador12numeros.Properties.Resources._22;

            else if (carta[index3] == 23)
                pct3.Image = global::Sorteador12numeros.Properties.Resources._23;

            else if (carta[index3] == 24)
                pct3.Image = global::Sorteador12numeros.Properties.Resources._24;

            else if (carta[index3] == 25)
                pct3.Image = global::Sorteador12numeros.Properties.Resources._25;

            else if (carta[index3] == 26)
                pct3.Image = global::Sorteador12numeros.Properties.Resources._26;

            else if (carta[index3] == 27)
                pct3.Image = global::Sorteador12numeros.Properties.Resources._27;

            else if (carta[index3] == 28)
                pct3.Image = global::Sorteador12numeros.Properties.Resources._28;

            else if (carta[index3] == 29)
                pct3.Image = global::Sorteador12numeros.Properties.Resources._29;

            else if (carta[index3] == 30)
                pct3.Image = global::Sorteador12numeros.Properties.Resources._30;

            else if (carta[index3] == 31)
                pct3.Image = global::Sorteador12numeros.Properties.Resources._31;

            else if (carta[index3] == 32)
                pct3.Image = global::Sorteador12numeros.Properties.Resources._32;

            else if (carta[index3] == 33)
                pct3.Image = global::Sorteador12numeros.Properties.Resources._33;

            else if (carta[index3] == 34)
                pct3.Image = global::Sorteador12numeros.Properties.Resources._34;

            else if (carta[index3] == 35)
                pct3.Image = global::Sorteador12numeros.Properties.Resources._35;

            else if (carta[index3] == 36)
                pct3.Image = global::Sorteador12numeros.Properties.Resources._36;

            else if (carta[index3] == 37)
                pct3.Image = global::Sorteador12numeros.Properties.Resources._37;

            else if (carta[index3] == 38)
                pct3.Image = global::Sorteador12numeros.Properties.Resources._38;

            else if (carta[index3] == 39)
                pct3.Image = global::Sorteador12numeros.Properties.Resources._39;

            else if (carta[index3] == 40)
                pct3.Image = global::Sorteador12numeros.Properties.Resources._40;

            else if (carta[index3] == 41)
                pct3.Image = global::Sorteador12numeros.Properties.Resources._41;

            else if (carta[index3] == 42)
                pct3.Image = global::Sorteador12numeros.Properties.Resources._42;

            else if (carta[index3] == 43)
                pct3.Image = global::Sorteador12numeros.Properties.Resources._43;

            else if (carta[index3] == 44)
                pct3.Image = global::Sorteador12numeros.Properties.Resources._44;

            else if (carta[index3] == 45)
                pct3.Image = global::Sorteador12numeros.Properties.Resources._45;

            else if (carta[index3] == 46)
                pct3.Image = global::Sorteador12numeros.Properties.Resources._46;

            else if (carta[index3] == 47)
                pct3.Image = global::Sorteador12numeros.Properties.Resources._47;

            else if (carta[index3] == 48)
                pct3.Image = global::Sorteador12numeros.Properties.Resources._48;

            else if (carta[index3] == 49)
                pct3.Image = global::Sorteador12numeros.Properties.Resources._49;

            else if (carta[index3] == 50)
                pct3.Image = global::Sorteador12numeros.Properties.Resources._50;

            else if (carta[index3] == 51)
                pct3.Image = global::Sorteador12numeros.Properties.Resources._51;

            else if (carta[index3] == 52)
                pct3.Image = global::Sorteador12numeros.Properties.Resources._52;
        }
        private void distribuirCarta4()
        {
            pct4.Visible = true;
            int index4 = 4;
            if (carta[index4] == 1)
                pct4.Image = global::Sorteador12numeros.Properties.Resources._1;

            else if (carta[index4] == 2)
                pct4.Image = global::Sorteador12numeros.Properties.Resources._2;

            else if (carta[index4] == 3)
                pct4.Image = global::Sorteador12numeros.Properties.Resources._3;

            else if (carta[index4] == 4)
                pct4.Image = global::Sorteador12numeros.Properties.Resources._4;

            else if (carta[index4] == 5)
                pct4.Image = global::Sorteador12numeros.Properties.Resources._5;

            else if (carta[index4] == 6)
                pct4.Image = global::Sorteador12numeros.Properties.Resources._6;

            else if (carta[index4] == 7)
                pct4.Image = global::Sorteador12numeros.Properties.Resources._7;

            else if (carta[index4] == 8)
                pct4.Image = global::Sorteador12numeros.Properties.Resources._8;

            else if (carta[index4] == 9)
                pct4.Image = global::Sorteador12numeros.Properties.Resources._9;

            else if (carta[index4] == 10)
                pct4.Image = global::Sorteador12numeros.Properties.Resources._10;

            else if (carta[index4] == 11)
                pct4.Image = global::Sorteador12numeros.Properties.Resources._11;

            else if (carta[index4] == 12)
                pct4.Image = global::Sorteador12numeros.Properties.Resources._12;

            else if (carta[index4] == 13)
                pct4.Image = global::Sorteador12numeros.Properties.Resources._13;

            else if (carta[index4] == 14)
                pct4.Image = global::Sorteador12numeros.Properties.Resources._14;

            else if (carta[index4] == 15)
                pct4.Image = global::Sorteador12numeros.Properties.Resources._15;

            else if (carta[index4] == 16)
                pct4.Image = global::Sorteador12numeros.Properties.Resources._16;

            else if (carta[index4] == 17)
                pct4.Image = global::Sorteador12numeros.Properties.Resources._17;

            else if (carta[index4] == 18)
                pct4.Image = global::Sorteador12numeros.Properties.Resources._18;

            else if (carta[index4] == 19)
                pct4.Image = global::Sorteador12numeros.Properties.Resources._19;

            else if (carta[index4] == 20)
                pct4.Image = global::Sorteador12numeros.Properties.Resources._20;

            else if (carta[index4] == 21)
                pct4.Image = global::Sorteador12numeros.Properties.Resources._21;

            else if (carta[index4] == 22)
                pct4.Image = global::Sorteador12numeros.Properties.Resources._22;

            else if (carta[index4] == 23)
                pct4.Image = global::Sorteador12numeros.Properties.Resources._23;

            else if (carta[index4] == 24)
                pct4.Image = global::Sorteador12numeros.Properties.Resources._24;

            else if (carta[index4] == 25)
                pct4.Image = global::Sorteador12numeros.Properties.Resources._25;

            else if (carta[index4] == 26)
                pct4.Image = global::Sorteador12numeros.Properties.Resources._26;

            else if (carta[index4] == 27)
                pct4.Image = global::Sorteador12numeros.Properties.Resources._27;

            else if (carta[index4] == 28)
                pct4.Image = global::Sorteador12numeros.Properties.Resources._28;

            else if (carta[index4] == 29)
                pct4.Image = global::Sorteador12numeros.Properties.Resources._29;

            else if (carta[index4] == 30)
                pct4.Image = global::Sorteador12numeros.Properties.Resources._30;

            else if (carta[index4] == 31)
                pct4.Image = global::Sorteador12numeros.Properties.Resources._31;

            else if (carta[index4] == 32)
                pct4.Image = global::Sorteador12numeros.Properties.Resources._32;

            else if (carta[index4] == 33)
                pct4.Image = global::Sorteador12numeros.Properties.Resources._33;

            else if (carta[index4] == 34)
                pct4.Image = global::Sorteador12numeros.Properties.Resources._34;

            else if (carta[index4] == 35)
                pct4.Image = global::Sorteador12numeros.Properties.Resources._35;

            else if (carta[index4] == 36)
                pct4.Image = global::Sorteador12numeros.Properties.Resources._36;

            else if (carta[index4] == 37)
                pct4.Image = global::Sorteador12numeros.Properties.Resources._37;

            else if (carta[index4] == 38)
                pct4.Image = global::Sorteador12numeros.Properties.Resources._38;

            else if (carta[index4] == 39)
                pct4.Image = global::Sorteador12numeros.Properties.Resources._39;

            else if (carta[index4] == 40)
                pct4.Image = global::Sorteador12numeros.Properties.Resources._40;

            else if (carta[index4] == 41)
                pct4.Image = global::Sorteador12numeros.Properties.Resources._41;

            else if (carta[index4] == 42)
                pct4.Image = global::Sorteador12numeros.Properties.Resources._42;

            else if (carta[index4] == 43)
                pct4.Image = global::Sorteador12numeros.Properties.Resources._43;

            else if (carta[index4] == 44)
                pct4.Image = global::Sorteador12numeros.Properties.Resources._44;

            else if (carta[index4] == 45)
                pct4.Image = global::Sorteador12numeros.Properties.Resources._45;

            else if (carta[index4] == 46)
                pct4.Image = global::Sorteador12numeros.Properties.Resources._46;

            else if (carta[index4] == 47)
                pct4.Image = global::Sorteador12numeros.Properties.Resources._47;

            else if (carta[index4] == 48)
                pct4.Image = global::Sorteador12numeros.Properties.Resources._48;

            else if (carta[index4] == 49)
                pct4.Image = global::Sorteador12numeros.Properties.Resources._49;

            else if (carta[index4] == 50)
                pct4.Image = global::Sorteador12numeros.Properties.Resources._50;

            else if (carta[index4] == 51)
                pct4.Image = global::Sorteador12numeros.Properties.Resources._51;

            else if (carta[index4] == 52)
                pct4.Image = global::Sorteador12numeros.Properties.Resources._52;
        }
        private void distribuirCarta5()
        {
            pct5.Visible = true;
            int index5 = 5;
            if (carta[index5] == 1)
                pct5.Image = global::Sorteador12numeros.Properties.Resources._1;

            else if (carta[index5] == 2)
                pct5.Image = global::Sorteador12numeros.Properties.Resources._2;

            else if (carta[index5] == 3)
                pct5.Image = global::Sorteador12numeros.Properties.Resources._3;

            else if (carta[index5] == 4)
                pct5.Image = global::Sorteador12numeros.Properties.Resources._4;

            else if (carta[index5] == 5)
                pct5.Image = global::Sorteador12numeros.Properties.Resources._5;

            else if (carta[index5] == 6)
                pct5.Image = global::Sorteador12numeros.Properties.Resources._6;

            else if (carta[index5] == 7)
                pct5.Image = global::Sorteador12numeros.Properties.Resources._7;

            else if (carta[index5] == 8)
                pct5.Image = global::Sorteador12numeros.Properties.Resources._8;

            else if (carta[index5] == 9)
                pct5.Image = global::Sorteador12numeros.Properties.Resources._9;

            else if (carta[index5] == 10)
                pct5.Image = global::Sorteador12numeros.Properties.Resources._10;

            else if (carta[index5] == 11)
                pct5.Image = global::Sorteador12numeros.Properties.Resources._11;

            else if (carta[index5] == 12)
                pct5.Image = global::Sorteador12numeros.Properties.Resources._12;

            else if (carta[index5] == 13)
                pct5.Image = global::Sorteador12numeros.Properties.Resources._13;

            else if (carta[index5] == 14)
                pct5.Image = global::Sorteador12numeros.Properties.Resources._14;

            else if (carta[index5] == 15)
                pct5.Image = global::Sorteador12numeros.Properties.Resources._15;

            else if (carta[index5] == 16)
                pct5.Image = global::Sorteador12numeros.Properties.Resources._16;

            else if (carta[index5] == 17)
                pct5.Image = global::Sorteador12numeros.Properties.Resources._17;

            else if (carta[index5] == 18)
                pct5.Image = global::Sorteador12numeros.Properties.Resources._18;

            else if (carta[index5] == 19)
                pct5.Image = global::Sorteador12numeros.Properties.Resources._19;

            else if (carta[index5] == 20)
                pct5.Image = global::Sorteador12numeros.Properties.Resources._20;

            else if (carta[index5] == 21)
                pct5.Image = global::Sorteador12numeros.Properties.Resources._21;

            else if (carta[index5] == 22)
                pct5.Image = global::Sorteador12numeros.Properties.Resources._22;

            else if (carta[index5] == 23)
                pct5.Image = global::Sorteador12numeros.Properties.Resources._23;

            else if (carta[index5] == 24)
                pct5.Image = global::Sorteador12numeros.Properties.Resources._24;

            else if (carta[index5] == 25)
                pct5.Image = global::Sorteador12numeros.Properties.Resources._25;

            else if (carta[index5] == 26)
                pct5.Image = global::Sorteador12numeros.Properties.Resources._26;

            else if (carta[index5] == 27)
                pct5.Image = global::Sorteador12numeros.Properties.Resources._27;

            else if (carta[index5] == 28)
                pct5.Image = global::Sorteador12numeros.Properties.Resources._28;

            else if (carta[index5] == 29)
                pct5.Image = global::Sorteador12numeros.Properties.Resources._29;

            else if (carta[index5] == 30)
                pct5.Image = global::Sorteador12numeros.Properties.Resources._30;

            else if (carta[index5] == 31)
                pct5.Image = global::Sorteador12numeros.Properties.Resources._31;

            else if (carta[index5] == 32)
                pct5.Image = global::Sorteador12numeros.Properties.Resources._32;

            else if (carta[index5] == 33)
                pct5.Image = global::Sorteador12numeros.Properties.Resources._33;

            else if (carta[index5] == 34)
                pct5.Image = global::Sorteador12numeros.Properties.Resources._34;

            else if (carta[index5] == 35)
                pct5.Image = global::Sorteador12numeros.Properties.Resources._35;

            else if (carta[index5] == 36)
                pct5.Image = global::Sorteador12numeros.Properties.Resources._36;

            else if (carta[index5] == 37)
                pct5.Image = global::Sorteador12numeros.Properties.Resources._37;

            else if (carta[index5] == 38)
                pct5.Image = global::Sorteador12numeros.Properties.Resources._38;

            else if (carta[index5] == 39)
                pct5.Image = global::Sorteador12numeros.Properties.Resources._39;

            else if (carta[index5] == 40)
                pct5.Image = global::Sorteador12numeros.Properties.Resources._40;

            else if (carta[index5] == 41)
                pct5.Image = global::Sorteador12numeros.Properties.Resources._41;

            else if (carta[index5] == 42)
                pct5.Image = global::Sorteador12numeros.Properties.Resources._42;

            else if (carta[index5] == 43)
                pct5.Image = global::Sorteador12numeros.Properties.Resources._43;

            else if (carta[index5] == 44)
                pct5.Image = global::Sorteador12numeros.Properties.Resources._44;

            else if (carta[index5] == 45)
                pct5.Image = global::Sorteador12numeros.Properties.Resources._45;

            else if (carta[index5] == 46)
                pct5.Image = global::Sorteador12numeros.Properties.Resources._46;

            else if (carta[index5] == 47)
                pct5.Image = global::Sorteador12numeros.Properties.Resources._47;

            else if (carta[index5] == 48)
                pct5.Image = global::Sorteador12numeros.Properties.Resources._48;

            else if (carta[index5] == 49)
                pct5.Image = global::Sorteador12numeros.Properties.Resources._49;

            else if (carta[index5] == 50)
                pct5.Image = global::Sorteador12numeros.Properties.Resources._50;

            else if (carta[index5] == 51)
                pct5.Image = global::Sorteador12numeros.Properties.Resources._51;

            else if (carta[index5] == 52)
                pct5.Image = global::Sorteador12numeros.Properties.Resources._52;
        }
        private void distribuirCarta6()
        {
            pct6.Visible = true;
            int index6 = 6;
            if (carta[index6] == 1)
                pct6.Image = global::Sorteador12numeros.Properties.Resources._1;

            else if (carta[index6] == 2)
                pct6.Image = global::Sorteador12numeros.Properties.Resources._2;

            else if (carta[index6] == 3)
                pct6.Image = global::Sorteador12numeros.Properties.Resources._3;

            else if (carta[index6] == 4)
                pct6.Image = global::Sorteador12numeros.Properties.Resources._4;

            else if (carta[index6] == 5)
                pct6.Image = global::Sorteador12numeros.Properties.Resources._5;

            else if (carta[index6] == 6)
                pct6.Image = global::Sorteador12numeros.Properties.Resources._6;

            else if (carta[index6] == 7)
                pct6.Image = global::Sorteador12numeros.Properties.Resources._7;

            else if (carta[index6] == 8)
                pct6.Image = global::Sorteador12numeros.Properties.Resources._8;

            else if (carta[index6] == 9)
                pct6.Image = global::Sorteador12numeros.Properties.Resources._9;

            else if (carta[index6] == 10)
                pct6.Image = global::Sorteador12numeros.Properties.Resources._10;

            else if (carta[index6] == 11)
                pct6.Image = global::Sorteador12numeros.Properties.Resources._11;

            else if (carta[index6] == 12)
                pct6.Image = global::Sorteador12numeros.Properties.Resources._12;

            else if (carta[index6] == 13)
                pct6.Image = global::Sorteador12numeros.Properties.Resources._13;

            else if (carta[index6] == 14)
                pct6.Image = global::Sorteador12numeros.Properties.Resources._14;

            else if (carta[index6] == 15)
                pct6.Image = global::Sorteador12numeros.Properties.Resources._15;

            else if (carta[index6] == 16)
                pct6.Image = global::Sorteador12numeros.Properties.Resources._16;

            else if (carta[index6] == 17)
                pct6.Image = global::Sorteador12numeros.Properties.Resources._17;

            else if (carta[index6] == 18)
                pct6.Image = global::Sorteador12numeros.Properties.Resources._18;

            else if (carta[index6] == 19)
                pct6.Image = global::Sorteador12numeros.Properties.Resources._19;

            else if (carta[index6] == 20)
                pct6.Image = global::Sorteador12numeros.Properties.Resources._20;

            else if (carta[index6] == 21)
                pct6.Image = global::Sorteador12numeros.Properties.Resources._21;

            else if (carta[index6] == 22)
                pct6.Image = global::Sorteador12numeros.Properties.Resources._22;

            else if (carta[index6] == 23)
                pct6.Image = global::Sorteador12numeros.Properties.Resources._23;

            else if (carta[index6] == 24)
                pct6.Image = global::Sorteador12numeros.Properties.Resources._24;

            else if (carta[index6] == 25)
                pct6.Image = global::Sorteador12numeros.Properties.Resources._25;

            else if (carta[index6] == 26)
                pct6.Image = global::Sorteador12numeros.Properties.Resources._26;

            else if (carta[index6] == 27)
                pct6.Image = global::Sorteador12numeros.Properties.Resources._27;

            else if (carta[index6] == 28)
                pct6.Image = global::Sorteador12numeros.Properties.Resources._28;

            else if (carta[index6] == 29)
                pct6.Image = global::Sorteador12numeros.Properties.Resources._29;

            else if (carta[index6] == 30)
                pct6.Image = global::Sorteador12numeros.Properties.Resources._30;

            else if (carta[index6] == 31)
                pct6.Image = global::Sorteador12numeros.Properties.Resources._31;

            else if (carta[index6] == 32)
                pct6.Image = global::Sorteador12numeros.Properties.Resources._32;

            else if (carta[index6] == 33)
                pct6.Image = global::Sorteador12numeros.Properties.Resources._33;

            else if (carta[index6] == 34)
                pct6.Image = global::Sorteador12numeros.Properties.Resources._34;

            else if (carta[index6] == 35)
                pct6.Image = global::Sorteador12numeros.Properties.Resources._35;

            else if (carta[index6] == 36)
                pct6.Image = global::Sorteador12numeros.Properties.Resources._36;

            else if (carta[index6] == 37)
                pct6.Image = global::Sorteador12numeros.Properties.Resources._37;

            else if (carta[index6] == 38)
                pct6.Image = global::Sorteador12numeros.Properties.Resources._38;

            else if (carta[index6] == 39)
                pct6.Image = global::Sorteador12numeros.Properties.Resources._39;

            else if (carta[index6] == 40)
                pct6.Image = global::Sorteador12numeros.Properties.Resources._40;

            else if (carta[index6] == 41)
                pct6.Image = global::Sorteador12numeros.Properties.Resources._41;

            else if (carta[index6] == 42)
                pct6.Image = global::Sorteador12numeros.Properties.Resources._42;

            else if (carta[index6] == 43)
                pct6.Image = global::Sorteador12numeros.Properties.Resources._43;

            else if (carta[index6] == 44)
                pct6.Image = global::Sorteador12numeros.Properties.Resources._44;

            else if (carta[index6] == 45)
                pct6.Image = global::Sorteador12numeros.Properties.Resources._45;

            else if (carta[index6] == 46)
                pct6.Image = global::Sorteador12numeros.Properties.Resources._46;

            else if (carta[index6] == 47)
                pct6.Image = global::Sorteador12numeros.Properties.Resources._47;

            else if (carta[index6] == 48)
                pct6.Image = global::Sorteador12numeros.Properties.Resources._48;

            else if (carta[index6] == 49)
                pct6.Image = global::Sorteador12numeros.Properties.Resources._49;

            else if (carta[index6] == 50)
                pct6.Image = global::Sorteador12numeros.Properties.Resources._50;

            else if (carta[index6] == 51)
                pct6.Image = global::Sorteador12numeros.Properties.Resources._51;

            else if (carta[index6] == 52)
                pct6.Image = global::Sorteador12numeros.Properties.Resources._52;
        }
        private void distribuirCarta7()
        {
            pct7.Visible = true;
            int index7 = 7;
            if (carta[index7] == 1)
                pct7.Image = global::Sorteador12numeros.Properties.Resources._1;

            else if (carta[index7] == 2)
                pct7.Image = global::Sorteador12numeros.Properties.Resources._2;

            else if (carta[index7] == 3)
                pct7.Image = global::Sorteador12numeros.Properties.Resources._3;

            else if (carta[index7] == 4)
                pct7.Image = global::Sorteador12numeros.Properties.Resources._4;

            else if (carta[index7] == 5)
                pct7.Image = global::Sorteador12numeros.Properties.Resources._5;

            else if (carta[index7] == 6)
                pct7.Image = global::Sorteador12numeros.Properties.Resources._6;

            else if (carta[index7] == 7)
                pct7.Image = global::Sorteador12numeros.Properties.Resources._7;

            else if (carta[index7] == 8)
                pct7.Image = global::Sorteador12numeros.Properties.Resources._8;

            else if (carta[index7] == 9)
                pct7.Image = global::Sorteador12numeros.Properties.Resources._9;

            else if (carta[index7] == 10)
                pct7.Image = global::Sorteador12numeros.Properties.Resources._10;

            else if (carta[index7] == 11)
                pct7.Image = global::Sorteador12numeros.Properties.Resources._11;

            else if (carta[index7] == 12)
                pct7.Image = global::Sorteador12numeros.Properties.Resources._12;

            else if (carta[index7] == 13)
                pct7.Image = global::Sorteador12numeros.Properties.Resources._13;

            else if (carta[index7] == 14)
                pct7.Image = global::Sorteador12numeros.Properties.Resources._14;

            else if (carta[index7] == 15)
                pct7.Image = global::Sorteador12numeros.Properties.Resources._15;

            else if (carta[index7] == 16)
                pct7.Image = global::Sorteador12numeros.Properties.Resources._16;

            else if (carta[index7] == 17)
                pct7.Image = global::Sorteador12numeros.Properties.Resources._17;

            else if (carta[index7] == 18)
                pct7.Image = global::Sorteador12numeros.Properties.Resources._18;

            else if (carta[index7] == 19)
                pct7.Image = global::Sorteador12numeros.Properties.Resources._19;

            else if (carta[index7] == 20)
                pct7.Image = global::Sorteador12numeros.Properties.Resources._20;

            else if (carta[index7] == 21)
                pct7.Image = global::Sorteador12numeros.Properties.Resources._21;

            else if (carta[index7] == 22)
                pct7.Image = global::Sorteador12numeros.Properties.Resources._22;

            else if (carta[index7] == 23)
                pct7.Image = global::Sorteador12numeros.Properties.Resources._23;

            else if (carta[index7] == 24)
                pct7.Image = global::Sorteador12numeros.Properties.Resources._24;

            else if (carta[index7] == 25)
                pct7.Image = global::Sorteador12numeros.Properties.Resources._25;

            else if (carta[index7] == 26)
                pct7.Image = global::Sorteador12numeros.Properties.Resources._26;

            else if (carta[index7] == 27)
                pct7.Image = global::Sorteador12numeros.Properties.Resources._27;

            else if (carta[index7] == 28)
                pct7.Image = global::Sorteador12numeros.Properties.Resources._28;

            else if (carta[index7] == 29)
                pct7.Image = global::Sorteador12numeros.Properties.Resources._29;

            else if (carta[index7] == 30)
                pct7.Image = global::Sorteador12numeros.Properties.Resources._30;

            else if (carta[index7] == 31)
                pct7.Image = global::Sorteador12numeros.Properties.Resources._31;

            else if (carta[index7] == 32)
                pct7.Image = global::Sorteador12numeros.Properties.Resources._32;

            else if (carta[index7] == 33)
                pct7.Image = global::Sorteador12numeros.Properties.Resources._33;

            else if (carta[index7] == 34)
                pct7.Image = global::Sorteador12numeros.Properties.Resources._34;

            else if (carta[index7] == 35)
                pct7.Image = global::Sorteador12numeros.Properties.Resources._35;

            else if (carta[index7] == 36)
                pct7.Image = global::Sorteador12numeros.Properties.Resources._36;

            else if (carta[index7] == 37)
                pct7.Image = global::Sorteador12numeros.Properties.Resources._37;

            else if (carta[index7] == 38)
                pct7.Image = global::Sorteador12numeros.Properties.Resources._38;

            else if (carta[index7] == 39)
                pct7.Image = global::Sorteador12numeros.Properties.Resources._39;

            else if (carta[index7] == 40)
                pct7.Image = global::Sorteador12numeros.Properties.Resources._40;

            else if (carta[index7] == 41)
                pct7.Image = global::Sorteador12numeros.Properties.Resources._41;

            else if (carta[index7] == 42)
                pct7.Image = global::Sorteador12numeros.Properties.Resources._42;

            else if (carta[index7] == 43)
                pct7.Image = global::Sorteador12numeros.Properties.Resources._43;

            else if (carta[index7] == 44)
                pct7.Image = global::Sorteador12numeros.Properties.Resources._44;

            else if (carta[index7] == 45)
                pct7.Image = global::Sorteador12numeros.Properties.Resources._45;

            else if (carta[index7] == 46)
                pct7.Image = global::Sorteador12numeros.Properties.Resources._46;

            else if (carta[index7] == 47)
                pct7.Image = global::Sorteador12numeros.Properties.Resources._47;

            else if (carta[index7] == 48)
                pct7.Image = global::Sorteador12numeros.Properties.Resources._48;

            else if (carta[index7] == 49)
                pct7.Image = global::Sorteador12numeros.Properties.Resources._49;

            else if (carta[index7] == 50)
                pct7.Image = global::Sorteador12numeros.Properties.Resources._50;

            else if (carta[index7] == 51)
                pct7.Image = global::Sorteador12numeros.Properties.Resources._51;

            else if (carta[index7] == 52)
                pct7.Image = global::Sorteador12numeros.Properties.Resources._52;
        }
        private void distribuirCarta8()
        {
            pct8.Visible = true;
            int index8 = 8;
            if (carta[index8] == 1)
                pct8.Image = global::Sorteador12numeros.Properties.Resources._1;

            else if (carta[index8] == 2)
                pct8.Image = global::Sorteador12numeros.Properties.Resources._2;

            else if (carta[index8] == 3)
                pct8.Image = global::Sorteador12numeros.Properties.Resources._3;

            else if (carta[index8] == 4)
                pct8.Image = global::Sorteador12numeros.Properties.Resources._4;

            else if (carta[index8] == 5)
                pct8.Image = global::Sorteador12numeros.Properties.Resources._5;

            else if (carta[index8] == 6)
                pct8.Image = global::Sorteador12numeros.Properties.Resources._6;

            else if (carta[index8] == 7)
                pct8.Image = global::Sorteador12numeros.Properties.Resources._7;

            else if (carta[index8] == 8)
                pct8.Image = global::Sorteador12numeros.Properties.Resources._8;

            else if (carta[index8] == 9)
                pct8.Image = global::Sorteador12numeros.Properties.Resources._9;

            else if (carta[index8] == 10)
                pct8.Image = global::Sorteador12numeros.Properties.Resources._10;

            else if (carta[index8] == 11)
                pct8.Image = global::Sorteador12numeros.Properties.Resources._11;

            else if (carta[index8] == 12)
                pct8.Image = global::Sorteador12numeros.Properties.Resources._12;

            else if (carta[index8] == 13)
                pct8.Image = global::Sorteador12numeros.Properties.Resources._13;

            else if (carta[index8] == 14)
                pct8.Image = global::Sorteador12numeros.Properties.Resources._14;

            else if (carta[index8] == 15)
                pct8.Image = global::Sorteador12numeros.Properties.Resources._15;

            else if (carta[index8] == 16)
                pct8.Image = global::Sorteador12numeros.Properties.Resources._16;

            else if (carta[index8] == 17)
                pct8.Image = global::Sorteador12numeros.Properties.Resources._17;

            else if (carta[index8] == 18)
                pct8.Image = global::Sorteador12numeros.Properties.Resources._18;

            else if (carta[index8] == 19)
                pct8.Image = global::Sorteador12numeros.Properties.Resources._19;

            else if (carta[index8] == 20)
                pct8.Image = global::Sorteador12numeros.Properties.Resources._20;

            else if (carta[index8] == 21)
                pct8.Image = global::Sorteador12numeros.Properties.Resources._21;

            else if (carta[index8] == 22)
                pct8.Image = global::Sorteador12numeros.Properties.Resources._22;

            else if (carta[index8] == 23)
                pct8.Image = global::Sorteador12numeros.Properties.Resources._23;

            else if (carta[index8] == 24)
                pct8.Image = global::Sorteador12numeros.Properties.Resources._24;

            else if (carta[index8] == 25)
                pct8.Image = global::Sorteador12numeros.Properties.Resources._25;

            else if (carta[index8] == 26)
                pct8.Image = global::Sorteador12numeros.Properties.Resources._26;

            else if (carta[index8] == 27)
                pct8.Image = global::Sorteador12numeros.Properties.Resources._27;

            else if (carta[index8] == 28)
                pct8.Image = global::Sorteador12numeros.Properties.Resources._28;

            else if (carta[index8] == 29)
                pct8.Image = global::Sorteador12numeros.Properties.Resources._29;

            else if (carta[index8] == 30)
                pct8.Image = global::Sorteador12numeros.Properties.Resources._30;

            else if (carta[index8] == 31)
                pct8.Image = global::Sorteador12numeros.Properties.Resources._31;

            else if (carta[index8] == 32)
                pct8.Image = global::Sorteador12numeros.Properties.Resources._32;

            else if (carta[index8] == 33)
                pct8.Image = global::Sorteador12numeros.Properties.Resources._33;

            else if (carta[index8] == 34)
                pct8.Image = global::Sorteador12numeros.Properties.Resources._34;

            else if (carta[index8] == 35)
                pct8.Image = global::Sorteador12numeros.Properties.Resources._35;

            else if (carta[index8] == 36)
                pct8.Image = global::Sorteador12numeros.Properties.Resources._36;

            else if (carta[index8] == 37)
                pct8.Image = global::Sorteador12numeros.Properties.Resources._37;

            else if (carta[index8] == 38)
                pct8.Image = global::Sorteador12numeros.Properties.Resources._38;

            else if (carta[index8] == 39)
                pct8.Image = global::Sorteador12numeros.Properties.Resources._39;

            else if (carta[index8] == 40)
                pct8.Image = global::Sorteador12numeros.Properties.Resources._40;

            else if (carta[index8] == 41)
                pct8.Image = global::Sorteador12numeros.Properties.Resources._41;

            else if (carta[index8] == 42)
                pct8.Image = global::Sorteador12numeros.Properties.Resources._42;

            else if (carta[index8] == 43)
                pct8.Image = global::Sorteador12numeros.Properties.Resources._43;

            else if (carta[index8] == 44)
                pct8.Image = global::Sorteador12numeros.Properties.Resources._44;

            else if (carta[index8] == 45)
                pct8.Image = global::Sorteador12numeros.Properties.Resources._45;

            else if (carta[index8] == 46)
                pct8.Image = global::Sorteador12numeros.Properties.Resources._46;

            else if (carta[index8] == 47)
                pct8.Image = global::Sorteador12numeros.Properties.Resources._47;

            else if (carta[index8] == 48)
                pct8.Image = global::Sorteador12numeros.Properties.Resources._48;

            else if (carta[index8] == 49)
                pct8.Image = global::Sorteador12numeros.Properties.Resources._49;

            else if (carta[index8] == 50)
                pct8.Image = global::Sorteador12numeros.Properties.Resources._50;

            else if (carta[index8] == 51)
                pct8.Image = global::Sorteador12numeros.Properties.Resources._51;

            else if (carta[index8] == 52)
                pct8.Image = global::Sorteador12numeros.Properties.Resources._52;
        }
        private void distribuirCarta9()
        {
            pct9.Visible = true;
            int index9 = 9;
            if (carta[index9] == 1)
                pct9.Image = global::Sorteador12numeros.Properties.Resources._1;

            else if (carta[index9] == 2)
                pct9.Image = global::Sorteador12numeros.Properties.Resources._2;

            else if (carta[index9] == 3)
                pct9.Image = global::Sorteador12numeros.Properties.Resources._3;

            else if (carta[index9] == 4)
                pct9.Image = global::Sorteador12numeros.Properties.Resources._4;

            else if (carta[index9] == 5)
                pct9.Image = global::Sorteador12numeros.Properties.Resources._5;

            else if (carta[index9] == 6)
                pct9.Image = global::Sorteador12numeros.Properties.Resources._6;

            else if (carta[index9] == 7)
                pct9.Image = global::Sorteador12numeros.Properties.Resources._7;

            else if (carta[index9] == 8)
                pct9.Image = global::Sorteador12numeros.Properties.Resources._8;

            else if (carta[index9] == 9)
                pct9.Image = global::Sorteador12numeros.Properties.Resources._9;

            else if (carta[index9] == 10)
                pct9.Image = global::Sorteador12numeros.Properties.Resources._10;

            else if (carta[index9] == 11)
                pct9.Image = global::Sorteador12numeros.Properties.Resources._11;

            else if (carta[index9] == 12)
                pct9.Image = global::Sorteador12numeros.Properties.Resources._12;

            else if (carta[index9] == 13)
                pct9.Image = global::Sorteador12numeros.Properties.Resources._13;

            else if (carta[index9] == 14)
                pct9.Image = global::Sorteador12numeros.Properties.Resources._14;

            else if (carta[index9] == 15)
                pct9.Image = global::Sorteador12numeros.Properties.Resources._15;

            else if (carta[index9] == 16)
                pct9.Image = global::Sorteador12numeros.Properties.Resources._16;

            else if (carta[index9] == 17)
                pct9.Image = global::Sorteador12numeros.Properties.Resources._17;

            else if (carta[index9] == 18)
                pct9.Image = global::Sorteador12numeros.Properties.Resources._18;

            else if (carta[index9] == 19)
                pct9.Image = global::Sorteador12numeros.Properties.Resources._19;

            else if (carta[index9] == 20)
                pct9.Image = global::Sorteador12numeros.Properties.Resources._20;

            else if (carta[index9] == 21)
                pct9.Image = global::Sorteador12numeros.Properties.Resources._21;

            else if (carta[index9] == 22)
                pct9.Image = global::Sorteador12numeros.Properties.Resources._22;

            else if (carta[index9] == 23)
                pct9.Image = global::Sorteador12numeros.Properties.Resources._23;

            else if (carta[index9] == 24)
                pct9.Image = global::Sorteador12numeros.Properties.Resources._24;

            else if (carta[index9] == 25)
                pct9.Image = global::Sorteador12numeros.Properties.Resources._25;

            else if (carta[index9] == 26)
                pct9.Image = global::Sorteador12numeros.Properties.Resources._26;

            else if (carta[index9] == 27)
                pct9.Image = global::Sorteador12numeros.Properties.Resources._27;

            else if (carta[index9] == 28)
                pct9.Image = global::Sorteador12numeros.Properties.Resources._28;

            else if (carta[index9] == 29)
                pct9.Image = global::Sorteador12numeros.Properties.Resources._29;

            else if (carta[index9] == 30)
                pct9.Image = global::Sorteador12numeros.Properties.Resources._30;

            else if (carta[index9] == 31)
                pct9.Image = global::Sorteador12numeros.Properties.Resources._31;

            else if (carta[index9] == 32)
                pct9.Image = global::Sorteador12numeros.Properties.Resources._32;

            else if (carta[index9] == 33)
                pct9.Image = global::Sorteador12numeros.Properties.Resources._33;

            else if (carta[index9] == 34)
                pct9.Image = global::Sorteador12numeros.Properties.Resources._34;

            else if (carta[index9] == 35)
                pct9.Image = global::Sorteador12numeros.Properties.Resources._35;

            else if (carta[index9] == 36)
                pct9.Image = global::Sorteador12numeros.Properties.Resources._36;

            else if (carta[index9] == 37)
                pct9.Image = global::Sorteador12numeros.Properties.Resources._37;

            else if (carta[index9] == 38)
                pct9.Image = global::Sorteador12numeros.Properties.Resources._38;

            else if (carta[index9] == 39)
                pct9.Image = global::Sorteador12numeros.Properties.Resources._39;

            else if (carta[index9] == 40)
                pct9.Image = global::Sorteador12numeros.Properties.Resources._40;

            else if (carta[index9] == 41)
                pct9.Image = global::Sorteador12numeros.Properties.Resources._41;

            else if (carta[index9] == 42)
                pct9.Image = global::Sorteador12numeros.Properties.Resources._42;

            else if (carta[index9] == 43)
                pct9.Image = global::Sorteador12numeros.Properties.Resources._43;

            else if (carta[index9] == 44)
                pct9.Image = global::Sorteador12numeros.Properties.Resources._44;

            else if (carta[index9] == 45)
                pct9.Image = global::Sorteador12numeros.Properties.Resources._45;

            else if (carta[index9] == 46)
                pct9.Image = global::Sorteador12numeros.Properties.Resources._46;

            else if (carta[index9] == 47)
                pct9.Image = global::Sorteador12numeros.Properties.Resources._47;

            else if (carta[index9] == 48)
                pct9.Image = global::Sorteador12numeros.Properties.Resources._48;

            else if (carta[index9] == 49)
                pct9.Image = global::Sorteador12numeros.Properties.Resources._49;

            else if (carta[index9] == 50)
                pct9.Image = global::Sorteador12numeros.Properties.Resources._50;

            else if (carta[index9] == 51)
                pct9.Image = global::Sorteador12numeros.Properties.Resources._51;

            else if (carta[index9] == 52)
                pct9.Image = global::Sorteador12numeros.Properties.Resources._52;
        }
        private void distribuirCarta10()
        {
            pct10.Visible = true;
            int index10 = 10;
            if (carta[index10] == 1)
                pct10.Image = global::Sorteador12numeros.Properties.Resources._1;

            else if (carta[index10] == 2)
                pct10.Image = global::Sorteador12numeros.Properties.Resources._2;

            else if (carta[index10] == 3)
                pct10.Image = global::Sorteador12numeros.Properties.Resources._3;

            else if (carta[index10] == 4)
                pct10.Image = global::Sorteador12numeros.Properties.Resources._4;

            else if (carta[index10] == 5)
                pct10.Image = global::Sorteador12numeros.Properties.Resources._5;

            else if (carta[index10] == 6)
                pct10.Image = global::Sorteador12numeros.Properties.Resources._6;

            else if (carta[index10] == 7)
                pct10.Image = global::Sorteador12numeros.Properties.Resources._7;

            else if (carta[index10] == 8)
                pct10.Image = global::Sorteador12numeros.Properties.Resources._8;

            else if (carta[index10] == 9)
                pct10.Image = global::Sorteador12numeros.Properties.Resources._9;

            else if (carta[index10] == 10)
                pct10.Image = global::Sorteador12numeros.Properties.Resources._10;

            else if (carta[index10] == 11)
                pct10.Image = global::Sorteador12numeros.Properties.Resources._11;

            else if (carta[index10] == 12)
                pct10.Image = global::Sorteador12numeros.Properties.Resources._12;

            else if (carta[index10] == 13)
                pct10.Image = global::Sorteador12numeros.Properties.Resources._13;

            else if (carta[index10] == 14)
                pct10.Image = global::Sorteador12numeros.Properties.Resources._14;

            else if (carta[index10] == 15)
                pct10.Image = global::Sorteador12numeros.Properties.Resources._15;

            else if (carta[index10] == 16)
                pct10.Image = global::Sorteador12numeros.Properties.Resources._16;

            else if (carta[index10] == 17)
                pct10.Image = global::Sorteador12numeros.Properties.Resources._17;

            else if (carta[index10] == 18)
                pct10.Image = global::Sorteador12numeros.Properties.Resources._18;

            else if (carta[index10] == 19)
                pct10.Image = global::Sorteador12numeros.Properties.Resources._19;

            else if (carta[index10] == 20)
                pct10.Image = global::Sorteador12numeros.Properties.Resources._20;

            else if (carta[index10] == 21)
                pct10.Image = global::Sorteador12numeros.Properties.Resources._21;

            else if (carta[index10] == 22)
                pct10.Image = global::Sorteador12numeros.Properties.Resources._22;

            else if (carta[index10] == 23)
                pct10.Image = global::Sorteador12numeros.Properties.Resources._23;

            else if (carta[index10] == 24)
                pct10.Image = global::Sorteador12numeros.Properties.Resources._24;

            else if (carta[index10] == 25)
                pct10.Image = global::Sorteador12numeros.Properties.Resources._25;

            else if (carta[index10] == 26)
                pct10.Image = global::Sorteador12numeros.Properties.Resources._26;

            else if (carta[index10] == 27)
                pct10.Image = global::Sorteador12numeros.Properties.Resources._27;

            else if (carta[index10] == 28)
                pct10.Image = global::Sorteador12numeros.Properties.Resources._28;

            else if (carta[index10] == 29)
                pct10.Image = global::Sorteador12numeros.Properties.Resources._29;

            else if (carta[index10] == 30)
                pct10.Image = global::Sorteador12numeros.Properties.Resources._30;

            else if (carta[index10] == 31)
                pct10.Image = global::Sorteador12numeros.Properties.Resources._31;

            else if (carta[index10] == 32)
                pct10.Image = global::Sorteador12numeros.Properties.Resources._32;

            else if (carta[index10] == 33)
                pct10.Image = global::Sorteador12numeros.Properties.Resources._33;

            else if (carta[index10] == 34)
                pct10.Image = global::Sorteador12numeros.Properties.Resources._34;

            else if (carta[index10] == 35)
                pct10.Image = global::Sorteador12numeros.Properties.Resources._35;

            else if (carta[index10] == 36)
                pct10.Image = global::Sorteador12numeros.Properties.Resources._36;

            else if (carta[index10] == 37)
                pct10.Image = global::Sorteador12numeros.Properties.Resources._37;

            else if (carta[index10] == 38)
                pct10.Image = global::Sorteador12numeros.Properties.Resources._38;

            else if (carta[index10] == 39)
                pct10.Image = global::Sorteador12numeros.Properties.Resources._39;

            else if (carta[index10] == 40)
                pct10.Image = global::Sorteador12numeros.Properties.Resources._40;

            else if (carta[index10] == 41)
                pct10.Image = global::Sorteador12numeros.Properties.Resources._41;

            else if (carta[index10] == 42)
                pct10.Image = global::Sorteador12numeros.Properties.Resources._42;

            else if (carta[index10] == 43)
                pct10.Image = global::Sorteador12numeros.Properties.Resources._43;

            else if (carta[index10] == 44)
                pct10.Image = global::Sorteador12numeros.Properties.Resources._44;

            else if (carta[index10] == 45)
                pct10.Image = global::Sorteador12numeros.Properties.Resources._45;

            else if (carta[index10] == 46)
                pct10.Image = global::Sorteador12numeros.Properties.Resources._46;

            else if (carta[index10] == 47)
                pct10.Image = global::Sorteador12numeros.Properties.Resources._47;

            else if (carta[index10] == 48)
                pct10.Image = global::Sorteador12numeros.Properties.Resources._48;

            else if (carta[index10] == 49)
                pct10.Image = global::Sorteador12numeros.Properties.Resources._49;

            else if (carta[index10] == 50)
                pct10.Image = global::Sorteador12numeros.Properties.Resources._50;

            else if (carta[index10] == 51)
                pct10.Image = global::Sorteador12numeros.Properties.Resources._51;

            else if (carta[index10] == 52)
                pct10.Image = global::Sorteador12numeros.Properties.Resources._52;
        }
        private void distribuirCarta11()
        {
            pct11.Visible = true;
            int index11 = 11;
            if (carta[index11] == 1)
                pct11.Image = global::Sorteador12numeros.Properties.Resources._1;

            else if (carta[index11] == 2)
                pct11.Image = global::Sorteador12numeros.Properties.Resources._2;

            else if (carta[index11] == 3)
                pct11.Image = global::Sorteador12numeros.Properties.Resources._3;

            else if (carta[index11] == 4)
                pct11.Image = global::Sorteador12numeros.Properties.Resources._4;

            else if (carta[index11] == 5)
                pct11.Image = global::Sorteador12numeros.Properties.Resources._5;

            else if (carta[index11] == 6)
                pct11.Image = global::Sorteador12numeros.Properties.Resources._6;

            else if (carta[index11] == 7)
                pct11.Image = global::Sorteador12numeros.Properties.Resources._7;

            else if (carta[index11] == 8)
                pct11.Image = global::Sorteador12numeros.Properties.Resources._8;

            else if (carta[index11] == 9)
                pct11.Image = global::Sorteador12numeros.Properties.Resources._9;

            else if (carta[index11] == 10)
                pct11.Image = global::Sorteador12numeros.Properties.Resources._10;

            else if (carta[index11] == 11)
                pct11.Image = global::Sorteador12numeros.Properties.Resources._11;

            else if (carta[index11] == 12)
                pct11.Image = global::Sorteador12numeros.Properties.Resources._12;

            else if (carta[index11] == 13)
                pct11.Image = global::Sorteador12numeros.Properties.Resources._13;

            else if (carta[index11] == 14)
                pct11.Image = global::Sorteador12numeros.Properties.Resources._14;

            else if (carta[index11] == 15)
                pct11.Image = global::Sorteador12numeros.Properties.Resources._15;

            else if (carta[index11] == 16)
                pct11.Image = global::Sorteador12numeros.Properties.Resources._16;

            else if (carta[index11] == 17)
                pct11.Image = global::Sorteador12numeros.Properties.Resources._17;

            else if (carta[index11] == 18)
                pct11.Image = global::Sorteador12numeros.Properties.Resources._18;

            else if (carta[index11] == 19)
                pct11.Image = global::Sorteador12numeros.Properties.Resources._19;

            else if (carta[index11] == 20)
                pct11.Image = global::Sorteador12numeros.Properties.Resources._20;

            else if (carta[index11] == 21)
                pct11.Image = global::Sorteador12numeros.Properties.Resources._21;

            else if (carta[index11] == 22)
                pct11.Image = global::Sorteador12numeros.Properties.Resources._22;

            else if (carta[index11] == 23)
                pct11.Image = global::Sorteador12numeros.Properties.Resources._23;

            else if (carta[index11] == 24)
                pct11.Image = global::Sorteador12numeros.Properties.Resources._24;

            else if (carta[index11] == 25)
                pct11.Image = global::Sorteador12numeros.Properties.Resources._25;

            else if (carta[index11] == 26)
                pct11.Image = global::Sorteador12numeros.Properties.Resources._26;

            else if (carta[index11] == 27)
                pct11.Image = global::Sorteador12numeros.Properties.Resources._27;

            else if (carta[index11] == 28)
                pct11.Image = global::Sorteador12numeros.Properties.Resources._28;

            else if (carta[index11] == 29)
                pct11.Image = global::Sorteador12numeros.Properties.Resources._29;

            else if (carta[index11] == 30)
                pct11.Image = global::Sorteador12numeros.Properties.Resources._30;

            else if (carta[index11] == 31)
                pct11.Image = global::Sorteador12numeros.Properties.Resources._31;

            else if (carta[index11] == 32)
                pct11.Image = global::Sorteador12numeros.Properties.Resources._32;

            else if (carta[index11] == 33)
                pct11.Image = global::Sorteador12numeros.Properties.Resources._33;

            else if (carta[index11] == 34)
                pct11.Image = global::Sorteador12numeros.Properties.Resources._34;

            else if (carta[index11] == 35)
                pct11.Image = global::Sorteador12numeros.Properties.Resources._35;

            else if (carta[index11] == 36)
                pct11.Image = global::Sorteador12numeros.Properties.Resources._36;

            else if (carta[index11] == 37)
                pct11.Image = global::Sorteador12numeros.Properties.Resources._37;

            else if (carta[index11] == 38)
                pct11.Image = global::Sorteador12numeros.Properties.Resources._38;

            else if (carta[index11] == 39)
                pct11.Image = global::Sorteador12numeros.Properties.Resources._39;

            else if (carta[index11] == 40)
                pct11.Image = global::Sorteador12numeros.Properties.Resources._40;

            else if (carta[index11] == 41)
                pct11.Image = global::Sorteador12numeros.Properties.Resources._41;

            else if (carta[index11] == 42)
                pct11.Image = global::Sorteador12numeros.Properties.Resources._42;

            else if (carta[index11] == 43)
                pct11.Image = global::Sorteador12numeros.Properties.Resources._43;

            else if (carta[index11] == 44)
                pct11.Image = global::Sorteador12numeros.Properties.Resources._44;

            else if (carta[index11] == 45)
                pct11.Image = global::Sorteador12numeros.Properties.Resources._45;

            else if (carta[index11] == 46)
                pct11.Image = global::Sorteador12numeros.Properties.Resources._46;

            else if (carta[index11] == 47)
                pct11.Image = global::Sorteador12numeros.Properties.Resources._47;

            else if (carta[index11] == 48)
                pct11.Image = global::Sorteador12numeros.Properties.Resources._48;

            else if (carta[index11] == 49)
                pct11.Image = global::Sorteador12numeros.Properties.Resources._49;

            else if (carta[index11] == 50)
                pct11.Image = global::Sorteador12numeros.Properties.Resources._50;

            else if (carta[index11] == 51)
                pct11.Image = global::Sorteador12numeros.Properties.Resources._51;

            else if (carta[index11] == 52)
                pct11.Image = global::Sorteador12numeros.Properties.Resources._52;
        }
        private void atribuirValorCarta0()
        {
            // Nesta parte, transforma a primeira carta da banca em um valor, para saber a pontuação.

            int index0 = 0;

            // Valor dos 4 Ases Copas, Espada, Ouro e Paus
            // Se tiver 2 cartas, vale 11. Acima disso, vale 1
            if ((carta[index0] == 1) || (carta[index0] == 14) || (carta[index0] == 27) || (carta[index0] == 40))
                if (quantCartasBanca == 2)
                    valorCarta[index0] = 11;
                else
                    valorCarta[index0] = 1;

            // Valor das 3 figuras Copas
            else if ((carta[index0] == 11) || (carta[index0] == 12) || (carta[index0] == 13))
                valorCarta[index0] = 10;

            //Valor das 3 figuras de Espada
            else if ((carta[index0] == 24) || (carta[index0] == 25) || (carta[index0] == 26))
                valorCarta[index0] = 10;

            //Valor das 3 figuras de Ouro
            else if ((carta[index0] == 37) || (carta[index0] == 38) || (carta[index0] == 39))
                valorCarta[index0] = 10;

            //Valor das 3 figuras de Paus
            else if ((carta[index0] == 50) || (carta[index0] == 51) || (carta[index0] == 52))
                valorCarta[index0] = 10;

            //Valor das 4 cartas número 10
            else if ((carta[index0] == 10) || (carta[index0] == 23) || (carta[index0] == 36) || (carta[index0] == 49))
                valorCarta[index0] = 10;

            //Valor das 4 cartas número 9
            else if ((carta[index0] == 9) || (carta[index0] == 22) || (carta[index0] == 35) || (carta[index0] == 48))
                valorCarta[index0] = 9;

            //Valor das 4 cartas número 8
            else if ((carta[index0] == 8) || (carta[index0] == 21) || (carta[index0] == 34) || (carta[index0] == 47))
                valorCarta[index0] = 8;

            //Valor das 4 cartas número 7
            else if ((carta[index0] == 7) || (carta[index0] == 20) || (carta[index0] == 33) || (carta[index0] == 46))
                valorCarta[index0] = 7;

            //Valor das 4 cartas número 6
            else if ((carta[index0] == 6) || (carta[index0] == 19) || (carta[index0] == 32) || (carta[index0] == 45))
                valorCarta[index0] = 6;

            //Valor das 4 cartas número 5
            else if ((carta[index0] == 5) || (carta[index0] == 18) || (carta[index0] == 31) || (carta[index0] == 44))
                valorCarta[index0] = 5;

            //Valor das 4 cartas número 4
            else if ((carta[index0] == 4) || (carta[index0] == 17) || (carta[index0] == 30) || (carta[index0] == 43))
                valorCarta[index0] = 4;

            //Valor das 4 cartas número 3
            else if ((carta[index0] == 3) || (carta[index0] == 16) || (carta[index0] == 29) || (carta[index0] == 42))
                valorCarta[index0] = 3;

            //Valor das 4 cartas número 2
            else if ((carta[index0] == 2) || (carta[index0] == 15) || (carta[index0] == 28) || (carta[index0] == 41))
                valorCarta[index0] = 2;
        }
        private void atribuirValorCarta1()
        {
            // Nesta parte, transforma a carta em um valor, para saber a pontuação.

            int index1 = 1;

            // Valor dos 4 Ases Copas, Espada, Ouro e Paus
            if ((carta[index1] == 1) || (carta[index1] == 14) || (carta[index1] == 27) || (carta[index1] == 40))
                if (quantCartasBanca == 2)
                    valorCarta[index1] = 11;
                else
                    valorCarta[index1] = 1;


            // Valor das 3 figuras Copas
            else if ((carta[index1] == 11) || (carta[index1] == 12) || (carta[index1] == 13))
                valorCarta[index1] = 10;

            //Valor das 3 figuras de Espada
            else if ((carta[index1] == 24) || (carta[index1] == 25) || (carta[index1] == 26))
                valorCarta[index1] = 10;

            //Valor das 3 figuras de Ouro
            else if ((carta[index1] == 37) || (carta[index1] == 38) || (carta[index1] == 39))
                valorCarta[index1] = 10;

            //Valor das 3 figuras de Paus
            else if ((carta[index1] == 50) || (carta[index1] == 51) || (carta[index1] == 52))
                valorCarta[index1] = 10;

            //Valor das 4 cartas número 10
            else if ((carta[index1] == 10) || (carta[index1] == 23) || (carta[index1] == 36) || (carta[index1] == 49))
                valorCarta[index1] = 10;

            //Valor das 4 cartas número 9
            else if ((carta[index1] == 9) || (carta[index1] == 22) || (carta[index1] == 35) || (carta[index1] == 48))
                valorCarta[index1] = 9;

            //Valor das 4 cartas número 8
            else if ((carta[index1] == 8) || (carta[index1] == 21) || (carta[index1] == 34) || (carta[index1] == 47))
                valorCarta[index1] = 8;

            //Valor das 4 cartas número 7
            else if ((carta[index1] == 7) || (carta[index1] == 20) || (carta[index1] == 33) || (carta[index1] == 46))
                valorCarta[index1] = 7;

            //Valor das 4 cartas número 6
            else if ((carta[index1] == 6) || (carta[index1] == 19) || (carta[index1] == 32) || (carta[index1] == 45))
                valorCarta[index1] = 6;

            //Valor das 4 cartas número 5
            else if ((carta[index1] == 5) || (carta[index1] == 18) || (carta[index1] == 31) || (carta[index1] == 44))
                valorCarta[index1] = 5;

            //Valor das 4 cartas número 4
            else if ((carta[index1] == 4) || (carta[index1] == 17) || (carta[index1] == 30) || (carta[index1] == 43))
                valorCarta[index1] = 4;

            //Valor das 4 cartas número 3
            else if ((carta[index1] == 3) || (carta[index1] == 16) || (carta[index1] == 29) || (carta[index1] == 42))
                valorCarta[index1] = 3;

            //Valor das 4 cartas número 2
            else if ((carta[index1] == 2) || (carta[index1] == 15) || (carta[index1] == 28) || (carta[index1] == 41))
                valorCarta[index1] = 2;
        }
        private void atribuirValorCarta2()
        {
            // Nesta parte, transforma a carta em um valor, para saber a pontuação.

            int index2 = 2;

            // Valor dos 4 Ases Copas, Espada, Ouro e Paus
            if ((carta[index2] == 1) || (carta[index2] == 14) || (carta[index2] == 27) || (carta[index2] == 40))
                if (quantCartasBanca == 2)
                    valorCarta[index2] = 11;
                else
                    valorCarta[index2] = 1;

            // Valor das 3 figuras Copas
            else if ((carta[index2] == 11) || (carta[index2] == 12) || (carta[index2] == 13))
                valorCarta[index2] = 10;

            //Valor das 3 figuras de Espada
            else if ((carta[index2] == 24) || (carta[index2] == 25) || (carta[index2] == 26))
                valorCarta[index2] = 10;

            //Valor das 3 figuras de Ouro
            else if ((carta[index2] == 37) || (carta[index2] == 38) || (carta[index2] == 39))
                valorCarta[index2] = 10;

            //Valor das 3 figuras de Paus
            else if ((carta[index2] == 50) || (carta[index2] == 51) || (carta[index2] == 52))
                valorCarta[index2] = 10;

            //Valor das 4 cartas número 10
            else if ((carta[index2] == 10) || (carta[index2] == 23) || (carta[index2] == 36) || (carta[index2] == 49))
                valorCarta[index2] = 10;

            //Valor das 4 cartas número 9
            else if ((carta[index2] == 9) || (carta[index2] == 22) || (carta[index2] == 35) || (carta[index2] == 48))
                valorCarta[index2] = 9;

            //Valor das 4 cartas número 8
            else if ((carta[index2] == 8) || (carta[index2] == 21) || (carta[index2] == 34) || (carta[index2] == 47))
                valorCarta[index2] = 8;

            //Valor das 4 cartas número 7
            else if ((carta[index2] == 7) || (carta[index2] == 20) || (carta[index2] == 33) || (carta[index2] == 46))
                valorCarta[index2] = 7;

            //Valor das 4 cartas número 6
            else if ((carta[index2] == 6) || (carta[index2] == 19) || (carta[index2] == 32) || (carta[index2] == 45))
                valorCarta[index2] = 6;

            //Valor das 4 cartas número 5
            else if ((carta[index2] == 5) || (carta[index2] == 18) || (carta[index2] == 31) || (carta[index2] == 44))
                valorCarta[index2] = 5;

            //Valor das 4 cartas número 4
            else if ((carta[index2] == 4) || (carta[index2] == 17) || (carta[index2] == 30) || (carta[index2] == 43))
                valorCarta[index2] = 4;

            //Valor das 4 cartas número 3
            else if ((carta[index2] == 3) || (carta[index2] == 16) || (carta[index2] == 29) || (carta[index2] == 42))
                valorCarta[index2] = 3;

            //Valor das 4 cartas número 2
            else if ((carta[index2] == 2) || (carta[index2] == 15) || (carta[index2] == 28) || (carta[index2] == 41))
                valorCarta[index2] = 2;
        }
        private void atribuirValorCarta3()
        {
            // Nesta parte, transforma a carta em um valor, para saber a pontuação.

            int index3 = 3;

            // Valor dos 4 Ases Copas, Espada, Ouro e Paus
            if ((carta[index3] == 1) || (carta[index3] == 14) || (carta[index3] == 27) || (carta[index3] == 40))
                if (quantCartasBanca == 2)
                    valorCarta[index3] = 11;
                else
                    valorCarta[index3] = 1;

            // Valor das 3 figuras Copas
            else if ((carta[index3] == 11) || (carta[index3] == 12) || (carta[index3] == 13))
                valorCarta[index3] = 10;

            //Valor das 3 figuras de Espada
            else if ((carta[index3] == 24) || (carta[index3] == 25) || (carta[index3] == 26))
                valorCarta[index3] = 10;

            //Valor das 3 figuras de Ouro
            else if ((carta[index3] == 37) || (carta[index3] == 38) || (carta[index3] == 39))
                valorCarta[index3] = 10;

            //Valor das 3 figuras de Paus
            else if ((carta[index3] == 50) || (carta[index3] == 51) || (carta[index3] == 52))
                valorCarta[index3] = 10;

            //Valor das 4 cartas número 10
            else if ((carta[index3] == 10) || (carta[index3] == 23) || (carta[index3] == 36) || (carta[index3] == 49))
                valorCarta[index3] = 10;

            //Valor das 4 cartas número 9
            else if ((carta[index3] == 9) || (carta[index3] == 22) || (carta[index3] == 35) || (carta[index3] == 48))
                valorCarta[index3] = 9;

            //Valor das 4 cartas número 8
            else if ((carta[index3] == 8) || (carta[index3] == 21) || (carta[index3] == 34) || (carta[index3] == 47))
                valorCarta[index3] = 8;

            //Valor das 4 cartas número 7
            else if ((carta[index3] == 7) || (carta[index3] == 20) || (carta[index3] == 33) || (carta[index3] == 46))
                valorCarta[index3] = 7;

            //Valor das 4 cartas número 6
            else if ((carta[index3] == 6) || (carta[index3] == 19) || (carta[index3] == 32) || (carta[index3] == 45))
                valorCarta[index3] = 6;

            //Valor das 4 cartas número 5
            else if ((carta[index3] == 5) || (carta[index3] == 18) || (carta[index3] == 31) || (carta[index3] == 44))
                valorCarta[index3] = 5;

            //Valor das 4 cartas número 4
            else if ((carta[index3] == 4) || (carta[index3] == 17) || (carta[index3] == 30) || (carta[index3] == 43))
                valorCarta[index3] = 4;

            //Valor das 4 cartas número 3
            else if ((carta[index3] == 3) || (carta[index3] == 16) || (carta[index3] == 29) || (carta[index3] == 42))
                valorCarta[index3] = 3;

            //Valor das 4 cartas número 2
            else if ((carta[index3] == 2) || (carta[index3] == 15) || (carta[index3] == 28) || (carta[index3] == 41))
                valorCarta[index3] = 2;
        }
        private void atribuirValorCarta4()
        {
            // Nesta parte, transforma a carta em um valor, para saber a pontuação.

            int index4 = 4;

            // Valor dos 4 Ases Copas, Espada, Ouro e Paus
            if ((carta[index4] == 1) || (carta[index4] == 14) || (carta[index4] == 27) || (carta[index4] == 40))
                if (quantCartasBanca == 2)
                    valorCarta[index4] = 11;
                else
                    valorCarta[index4] = 1;

            // Valor das 3 figuras Copas
            else if ((carta[index4] == 11) || (carta[index4] == 12) || (carta[index4] == 13))
                valorCarta[index4] = 10;

            //Valor das 3 figuras de Espada
            else if ((carta[index4] == 24) || (carta[index4] == 25) || (carta[index4] == 26))
                valorCarta[index4] = 10;

            //Valor das 3 figuras de Ouro
            else if ((carta[index4] == 37) || (carta[index4] == 38) || (carta[index4] == 39))
                valorCarta[index4] = 10;

            //Valor das 3 figuras de Paus
            else if ((carta[index4] == 50) || (carta[index4] == 51) || (carta[index4] == 52))
                valorCarta[index4] = 10;

            //Valor das 4 cartas número 10
            else if ((carta[index4] == 10) || (carta[index4] == 23) || (carta[index4] == 36) || (carta[index4] == 49))
                valorCarta[index4] = 10;

            //Valor das 4 cartas número 9
            else if ((carta[index4] == 9) || (carta[index4] == 22) || (carta[index4] == 35) || (carta[index4] == 48))
                valorCarta[index4] = 9;

            //Valor das 4 cartas número 8
            else if ((carta[index4] == 8) || (carta[index4] == 21) || (carta[index4] == 34) || (carta[index4] == 47))
                valorCarta[index4] = 8;

            //Valor das 4 cartas número 7
            else if ((carta[index4] == 7) || (carta[index4] == 20) || (carta[index4] == 33) || (carta[index4] == 46))
                valorCarta[index4] = 7;

            //Valor das 4 cartas número 6
            else if ((carta[index4] == 6) || (carta[index4] == 19) || (carta[index4] == 32) || (carta[index4] == 45))
                valorCarta[index4] = 6;

            //Valor das 4 cartas número 5
            else if ((carta[index4] == 5) || (carta[index4] == 18) || (carta[index4] == 31) || (carta[index4] == 44))
                valorCarta[index4] = 5;

            //Valor das 4 cartas número 4
            else if ((carta[index4] == 4) || (carta[index4] == 17) || (carta[index4] == 30) || (carta[index4] == 43))
                valorCarta[index4] = 4;

            //Valor das 4 cartas número 3
            else if ((carta[index4] == 3) || (carta[index4] == 16) || (carta[index4] == 29) || (carta[index4] == 42))
                valorCarta[index4] = 3;

            //Valor das 4 cartas número 2
            else if ((carta[index4] == 2) || (carta[index4] == 15) || (carta[index4] == 28) || (carta[index4] == 41))
                valorCarta[index4] = 2;
        }
        private void atribuirValorCarta5()
        {
            // Nesta parte, transforma a carta em um valor, para saber a pontuação.

            int index5 = 5;

            // Valor dos 4 Ases Copas, Espada, Ouro e Paus
            if ((carta[index5] == 1) || (carta[index5] == 14) || (carta[index5] == 27) || (carta[index5] == 40))
                if (quantCartasBanca == 2)
                    valorCarta[index5] = 11;
                else
                    valorCarta[index5] = 1;

            // Valor das 3 figuras Copas
            else if ((carta[index5] == 11) || (carta[index5] == 12) || (carta[index5] == 13))
                valorCarta[index5] = 10;

            //Valor das 3 figuras de Espada
            else if ((carta[index5] == 24) || (carta[index5] == 25) || (carta[index5] == 26))
                valorCarta[index5] = 10;

            //Valor das 3 figuras de Ouro
            else if ((carta[index5] == 37) || (carta[index5] == 38) || (carta[index5] == 39))
                valorCarta[index5] = 10;

            //Valor das 3 figuras de Paus
            else if ((carta[index5] == 50) || (carta[index5] == 51) || (carta[index5] == 52))
                valorCarta[index5] = 10;

            //Valor das 4 cartas número 10
            else if ((carta[index5] == 10) || (carta[index5] == 23) || (carta[index5] == 36) || (carta[index5] == 49))
                valorCarta[index5] = 10;

            //Valor das 4 cartas número 9
            else if ((carta[index5] == 9) || (carta[index5] == 22) || (carta[index5] == 35) || (carta[index5] == 48))
                valorCarta[index5] = 9;

            //Valor das 4 cartas número 8
            else if ((carta[index5] == 8) || (carta[index5] == 21) || (carta[index5] == 34) || (carta[index5] == 47))
                valorCarta[index5] = 8;

            //Valor das 4 cartas número 7
            else if ((carta[index5] == 7) || (carta[index5] == 20) || (carta[index5] == 33) || (carta[index5] == 46))
                valorCarta[index5] = 7;

            //Valor das 4 cartas número 6
            else if ((carta[index5] == 6) || (carta[index5] == 19) || (carta[index5] == 32) || (carta[index5] == 45))
                valorCarta[index5] = 6;

            //Valor das 4 cartas número 5
            else if ((carta[index5] == 5) || (carta[index5] == 18) || (carta[index5] == 31) || (carta[index5] == 44))
                valorCarta[index5] = 5;

            //Valor das 4 cartas número 4
            else if ((carta[index5] == 4) || (carta[index5] == 17) || (carta[index5] == 30) || (carta[index5] == 43))
                valorCarta[index5] = 4;

            //Valor das 4 cartas número 3
            else if ((carta[index5] == 3) || (carta[index5] == 16) || (carta[index5] == 29) || (carta[index5] == 42))
                valorCarta[index5] = 3;

            //Valor das 4 cartas número 2
            else if ((carta[index5] == 2) || (carta[index5] == 15) || (carta[index5] == 28) || (carta[index5] == 41))
                valorCarta[index5] = 2;
        }
        private void atribuirValorCarta6()
        {
            // Nesta parte, transforma a carta em um valor, para saber a pontuação.

            int index6 = 6;

            // Valor dos 4 Ases Copas, Espada, Ouro e Paus
            if ((carta[index6] == 1) || (carta[index6] == 14) || (carta[index6] == 27) || (carta[index6] == 40))
                if (quantCartasJogador == 2)
                    valorCarta[index6] = 11;
                else
                    valorCarta[index6] = 1;

            // Valor das 3 figuras Copas
            else if ((carta[index6] == 11) || (carta[index6] == 12) || (carta[index6] == 13))
                valorCarta[index6] = 10;

            //Valor das 3 figuras de Espada
            else if ((carta[index6] == 24) || (carta[index6] == 25) || (carta[index6] == 26))
                valorCarta[index6] = 10;

            //Valor das 3 figuras de Ouro
            else if ((carta[index6] == 37) || (carta[index6] == 38) || (carta[index6] == 39))
                valorCarta[index6] = 10;

            //Valor das 3 figuras de Paus
            else if ((carta[index6] == 50) || (carta[index6] == 51) || (carta[index6] == 52))
                valorCarta[index6] = 10;

            //Valor das 4 cartas número 10
            else if ((carta[index6] == 10) || (carta[index6] == 23) || (carta[index6] == 36) || (carta[index6] == 49))
                valorCarta[index6] = 10;

            //Valor das 4 cartas número 9
            else if ((carta[index6] == 9) || (carta[index6] == 22) || (carta[index6] == 35) || (carta[index6] == 48))
                valorCarta[index6] = 9;

            //Valor das 4 cartas número 8
            else if ((carta[index6] == 8) || (carta[index6] == 21) || (carta[index6] == 34) || (carta[index6] == 47))
                valorCarta[index6] = 8;

            //Valor das 4 cartas número 7
            else if ((carta[index6] == 7) || (carta[index6] == 20) || (carta[index6] == 33) || (carta[index6] == 46))
                valorCarta[index6] = 7;

            //Valor das 4 cartas número 6
            else if ((carta[index6] == 6) || (carta[index6] == 19) || (carta[index6] == 32) || (carta[index6] == 45))
                valorCarta[index6] = 6;

            //Valor das 4 cartas número 5
            else if ((carta[index6] == 5) || (carta[index6] == 18) || (carta[index6] == 31) || (carta[index6] == 44))
                valorCarta[index6] = 5;

            //Valor das 4 cartas número 4
            else if ((carta[index6] == 4) || (carta[index6] == 17) || (carta[index6] == 30) || (carta[index6] == 43))
                valorCarta[index6] = 4;

            //Valor das 4 cartas número 3
            else if ((carta[index6] == 3) || (carta[index6] == 16) || (carta[index6] == 29) || (carta[index6] == 42))
                valorCarta[index6] = 3;

            //Valor das 4 cartas número 2
            else if ((carta[index6] == 2) || (carta[index6] == 15) || (carta[index6] == 28) || (carta[index6] == 41))
                valorCarta[index6] = 2;
        }
        private void atribuirValorCarta7()
        {
            // Nesta parte, transforma a carta em um valor, para saber a pontuação.

            int index7 = 7;

            // Valor dos 4 Ases Copas, Espada, Ouro e Paus
            if ((carta[index7] == 1) || (carta[index7] == 14) || (carta[index7] == 27) || (carta[index7] == 40))
                if (quantCartasJogador == 2)
                    valorCarta[index7] = 11;
                else
                    valorCarta[index7] = 1;

            // Valor das 3 figuras Copas
            else if ((carta[index7] == 11) || (carta[index7] == 12) || (carta[index7] == 13))
                valorCarta[index7] = 10;

            //Valor das 3 figuras de Espada
            else if ((carta[index7] == 24) || (carta[index7] == 25) || (carta[index7] == 26))
                valorCarta[index7] = 10;

            //Valor das 3 figuras de Ouro
            else if ((carta[index7] == 37) || (carta[index7] == 38) || (carta[index7] == 39))
                valorCarta[index7] = 10;

            //Valor das 3 figuras de Paus
            else if ((carta[index7] == 50) || (carta[index7] == 51) || (carta[index7] == 52))
                valorCarta[index7] = 10;

            //Valor das 4 cartas número 10
            else if ((carta[index7] == 10) || (carta[index7] == 23) || (carta[index7] == 36) || (carta[index7] == 49))
                valorCarta[index7] = 10;

            //Valor das 4 cartas número 9
            else if ((carta[index7] == 9) || (carta[index7] == 22) || (carta[index7] == 35) || (carta[index7] == 48))
                valorCarta[index7] = 9;

            //Valor das 4 cartas número 8
            else if ((carta[index7] == 8) || (carta[index7] == 21) || (carta[index7] == 34) || (carta[index7] == 47))
                valorCarta[index7] = 8;

            //Valor das 4 cartas número 7
            else if ((carta[index7] == 7) || (carta[index7] == 20) || (carta[index7] == 33) || (carta[index7] == 46))
                valorCarta[index7] = 7;

            //Valor das 4 cartas número 6
            else if ((carta[index7] == 6) || (carta[index7] == 19) || (carta[index7] == 32) || (carta[index7] == 45))
                valorCarta[index7] = 6;

            //Valor das 4 cartas número 5
            else if ((carta[index7] == 5) || (carta[index7] == 18) || (carta[index7] == 31) || (carta[index7] == 44))
                valorCarta[index7] = 5;

            //Valor das 4 cartas número 4
            else if ((carta[index7] == 4) || (carta[index7] == 17) || (carta[index7] == 30) || (carta[index7] == 43))
                valorCarta[index7] = 4;

            //Valor das 4 cartas número 3
            else if ((carta[index7] == 3) || (carta[index7] == 16) || (carta[index7] == 29) || (carta[index7] == 42))
                valorCarta[index7] = 3;

            //Valor das 4 cartas número 2
            else if ((carta[index7] == 2) || (carta[index7] == 15) || (carta[index7] == 28) || (carta[index7] == 41))
                valorCarta[index7] = 2;
        }
        private void atribuirValorCarta8()
        {
            // Nesta parte, transforma a carta em um valor, para saber a pontuação.

            int index8 = 8;

            // Valor dos 4 Ases Copas, Espada, Ouro e Paus
            if ((carta[index8] == 1) || (carta[index8] == 14) || (carta[index8] == 27) || (carta[index8] == 40))
                if (quantCartasJogador == 2)
                    valorCarta[index8] = 11;
                else
                    valorCarta[index8] = 1;

            // Valor das 3 figuras Copas
            else if ((carta[index8] == 11) || (carta[index8] == 12) || (carta[index8] == 13))
                valorCarta[index8] = 10;

            //Valor das 3 figuras de Espada
            else if ((carta[index8] == 24) || (carta[index8] == 25) || (carta[index8] == 26))
                valorCarta[index8] = 10;

            //Valor das 3 figuras de Ouro
            else if ((carta[index8] == 37) || (carta[index8] == 38) || (carta[index8] == 39))
                valorCarta[index8] = 10;

            //Valor das 3 figuras de Paus
            else if ((carta[index8] == 50) || (carta[index8] == 51) || (carta[index8] == 52))
                valorCarta[index8] = 10;

            //Valor das 4 cartas número 10
            else if ((carta[index8] == 10) || (carta[index8] == 23) || (carta[index8] == 36) || (carta[index8] == 49))
                valorCarta[index8] = 10;

            //Valor das 4 cartas número 9
            else if ((carta[index8] == 9) || (carta[index8] == 22) || (carta[index8] == 35) || (carta[index8] == 48))
                valorCarta[index8] = 9;

            //Valor das 4 cartas número 8
            else if ((carta[index8] == 8) || (carta[index8] == 21) || (carta[index8] == 34) || (carta[index8] == 47))
                valorCarta[index8] = 8;

            //Valor das 4 cartas número 7
            else if ((carta[index8] == 7) || (carta[index8] == 20) || (carta[index8] == 33) || (carta[index8] == 46))
                valorCarta[index8] = 7;

            //Valor das 4 cartas número 6
            else if ((carta[index8] == 6) || (carta[index8] == 19) || (carta[index8] == 32) || (carta[index8] == 45))
                valorCarta[index8] = 6;

            //Valor das 4 cartas número 5
            else if ((carta[index8] == 5) || (carta[index8] == 18) || (carta[index8] == 31) || (carta[index8] == 44))
                valorCarta[index8] = 5;

            //Valor das 4 cartas número 4
            else if ((carta[index8] == 4) || (carta[index8] == 17) || (carta[index8] == 30) || (carta[index8] == 43))
                valorCarta[index8] = 4;

            //Valor das 4 cartas número 3
            else if ((carta[index8] == 3) || (carta[index8] == 16) || (carta[index8] == 29) || (carta[index8] == 42))
                valorCarta[index8] = 3;

            //Valor das 4 cartas número 2
            else if ((carta[index8] == 2) || (carta[index8] == 15) || (carta[index8] == 28) || (carta[index8] == 41))
                valorCarta[index8] = 2;
        }
        private void atribuirValorCarta9()
        {
            // Nesta parte, transforma a carta em um valor, para saber a pontuação.

            int index9 = 9;

            // Valor dos 4 Ases Copas, Espada, Ouro e Paus
            if ((carta[index9] == 1) || (carta[index9] == 14) || (carta[index9] == 27) || (carta[index9] == 40))
                if (quantCartasJogador == 2)
                    valorCarta[index9] = 11;
                else
                    valorCarta[index9] = 1;

            // Valor das 3 figuras Copas
            else if ((carta[index9] == 11) || (carta[index9] == 12) || (carta[index9] == 13))
                valorCarta[index9] = 10;

            //Valor das 3 figuras de Espada
            else if ((carta[index9] == 24) || (carta[index9] == 25) || (carta[index9] == 26))
                valorCarta[index9] = 10;

            //Valor das 3 figuras de Ouro
            else if ((carta[index9] == 37) || (carta[index9] == 38) || (carta[index9] == 39))
                valorCarta[index9] = 10;

            //Valor das 3 figuras de Paus
            else if ((carta[index9] == 50) || (carta[index9] == 51) || (carta[index9] == 52))
                valorCarta[index9] = 10;

            //Valor das 4 cartas número 10
            else if ((carta[index9] == 10) || (carta[index9] == 23) || (carta[index9] == 36) || (carta[index9] == 49))
                valorCarta[index9] = 10;

            //Valor das 4 cartas número 9
            else if ((carta[index9] == 9) || (carta[index9] == 22) || (carta[index9] == 35) || (carta[index9] == 48))
                valorCarta[index9] = 9;

            //Valor das 4 cartas número 8
            else if ((carta[index9] == 8) || (carta[index9] == 21) || (carta[index9] == 34) || (carta[index9] == 47))
                valorCarta[index9] = 8;

            //Valor das 4 cartas número 7
            else if ((carta[index9] == 7) || (carta[index9] == 20) || (carta[index9] == 33) || (carta[index9] == 46))
                valorCarta[index9] = 7;

            //Valor das 4 cartas número 6
            else if ((carta[index9] == 6) || (carta[index9] == 19) || (carta[index9] == 32) || (carta[index9] == 45))
                valorCarta[index9] = 6;

            //Valor das 4 cartas número 5
            else if ((carta[index9] == 5) || (carta[index9] == 18) || (carta[index9] == 31) || (carta[index9] == 44))
                valorCarta[index9] = 5;

            //Valor das 4 cartas número 4
            else if ((carta[index9] == 4) || (carta[index9] == 17) || (carta[index9] == 30) || (carta[index9] == 43))
                valorCarta[index9] = 4;

            //Valor das 4 cartas número 3
            else if ((carta[index9] == 3) || (carta[index9] == 16) || (carta[index9] == 29) || (carta[index9] == 42))
                valorCarta[index9] = 3;

            //Valor das 4 cartas número 2
            else if ((carta[index9] == 2) || (carta[index9] == 15) || (carta[index9] == 28) || (carta[index9] == 41))
                valorCarta[index9] = 2;
        }
        private void atribuirValorCarta10()
        {
            // Nesta parte, transforma a carta em um valor, para saber a pontuação.

            int index10 = 10;

            // Valor dos 4 Ases Copas, Espada, Ouro e Paus
            if ((carta[index10] == 1) || (carta[index10] == 14) || (carta[index10] == 27) || (carta[index10] == 40))
                if (quantCartasJogador == 2)
                    valorCarta[index10] = 11;
                else
                    valorCarta[index10] = 1;

            // Valor das 3 figuras Copas
            else if ((carta[index10] == 11) || (carta[index10] == 12) || (carta[index10] == 13))
                valorCarta[index10] = 10;

            //Valor das 3 figuras de Espada
            else if ((carta[index10] == 24) || (carta[index10] == 25) || (carta[index10] == 26))
                valorCarta[index10] = 10;

            //Valor das 3 figuras de Ouro
            else if ((carta[index10] == 37) || (carta[index10] == 38) || (carta[index10] == 39))
                valorCarta[index10] = 10;

            //Valor das 3 figuras de Paus
            else if ((carta[index10] == 50) || (carta[index10] == 51) || (carta[index10] == 52))
                valorCarta[index10] = 10;

            //Valor das 4 cartas número 10
            else if ((carta[index10] == 10) || (carta[index10] == 23) || (carta[index10] == 36) || (carta[index10] == 49))
                valorCarta[index10] = 10;

            //Valor das 4 cartas número 9
            else if ((carta[index10] == 9) || (carta[index10] == 22) || (carta[index10] == 35) || (carta[index10] == 48))
                valorCarta[index10] = 9;

            //Valor das 4 cartas número 8
            else if ((carta[index10] == 8) || (carta[index10] == 21) || (carta[index10] == 34) || (carta[index10] == 47))
                valorCarta[index10] = 8;

            //Valor das 4 cartas número 7
            else if ((carta[index10] == 7) || (carta[index10] == 20) || (carta[index10] == 33) || (carta[index10] == 46))
                valorCarta[index10] = 7;

            //Valor das 4 cartas número 6
            else if ((carta[index10] == 6) || (carta[index10] == 19) || (carta[index10] == 32) || (carta[index10] == 45))
                valorCarta[index10] = 6;

            //Valor das 4 cartas número 5
            else if ((carta[index10] == 5) || (carta[index10] == 18) || (carta[index10] == 31) || (carta[index10] == 44))
                valorCarta[index10] = 5;

            //Valor das 4 cartas número 4
            else if ((carta[index10] == 4) || (carta[index10] == 17) || (carta[index10] == 30) || (carta[index10] == 43))
                valorCarta[index10] = 4;

            //Valor das 4 cartas número 3
            else if ((carta[index10] == 3) || (carta[index10] == 16) || (carta[index10] == 29) || (carta[index10] == 42))
                valorCarta[index10] = 3;

            //Valor das 4 cartas número 2
            else if ((carta[index10] == 2) || (carta[index10] == 15) || (carta[index10] == 28) || (carta[index10] == 41))
                valorCarta[index10] = 2;
        }
        private void atribuirValorCarta11()
        {
            // Nesta parte, transforma a carta em um valor, para saber a pontuação.

            int index11 = 11;

            // Valor dos 4 Ases Copas, Espada, Ouro e Paus
       
            if ((carta[index11] == 1) || (carta[index11] == 14) || (carta[index11] == 27) || (carta[index11] == 40))
                if (quantCartasJogador == 2)
                    valorCarta[index11] = 11;
                else
                    valorCarta[index11] = 1;

            // Valor das 3 figuras Copas
            else if ((carta[index11] == 11) || (carta[index11] == 12) || (carta[index11] == 13))
                valorCarta[index11] = 10;

            //Valor das 3 figuras de Espada
            else if ((carta[index11] == 24) || (carta[index11] == 25) || (carta[index11] == 26))
                valorCarta[index11] = 10;

            //Valor das 3 figuras de Ouro
            else if ((carta[index11] == 37) || (carta[index11] == 38) || (carta[index11] == 39))
                valorCarta[index11] = 10;

            //Valor das 3 figuras de Paus
            else if ((carta[index11] == 50) || (carta[index11] == 51) || (carta[index11] == 52))
                valorCarta[index11] = 10;

            //Valor das 4 cartas número 10
            else if ((carta[index11] == 10) || (carta[index11] == 23) || (carta[index11] == 36) || (carta[index11] == 49))
                valorCarta[index11] = 10;

            //Valor das 4 cartas número 9
            else if ((carta[index11] == 9) || (carta[index11] == 22) || (carta[index11] == 35) || (carta[index11] == 48))
                valorCarta[index11] = 9;

            //Valor das 4 cartas número 8
            else if ((carta[index11] == 8) || (carta[index11] == 21) || (carta[index11] == 34) || (carta[index11] == 47))
                valorCarta[index11] = 8;

            //Valor das 4 cartas número 7
            else if ((carta[index11] == 7) || (carta[index11] == 20) || (carta[index11] == 33) || (carta[index11] == 46))
                valorCarta[index11] = 7;

            //Valor das 4 cartas número 6
            else if ((carta[index11] == 6) || (carta[index11] == 19) || (carta[index11] == 32) || (carta[index11] == 45))
                valorCarta[index11] = 6;

            //Valor das 4 cartas número 5
            else if ((carta[index11] == 5) || (carta[index11] == 18) || (carta[index11] == 31) || (carta[index11] == 44))
                valorCarta[index11] = 5;

            //Valor das 4 cartas número 4
            else if ((carta[index11] == 4) || (carta[index11] == 17) || (carta[index11] == 30) || (carta[index11] == 43))
                valorCarta[index11] = 4;

            //Valor das 4 cartas número 3
            else if ((carta[index11] == 3) || (carta[index11] == 16) || (carta[index11] == 29) || (carta[index11] == 42))
                valorCarta[index11] = 3;

            //Valor das 4 cartas número 2
            else if ((carta[index11] == 2) || (carta[index11] == 15) || (carta[index11] == 28) || (carta[index11] == 41))
                valorCarta[index11] = 2;
        }

        private void btnMaisCarta1_Click(object sender, EventArgs e)
        {
            btnMaisCarta1.Visible = false;
            btnOK.Location = new Point(382, 296);

            // Altera a quantidade de cartas do jogador para 3, porque assim o As passa a valer 1 ponto 
            quantCartasJogador = 3;

            // Como alterou o valor do As, atribui os valores das cartas anteriores novamente
            atribuirValorCarta6();
            atribuirValorCarta7();

            // Açoes para mais cartas
            distribuirCarta8();
            atribuirValorCarta8(); 
            pontosJogador = valorCarta[6] + valorCarta[7] + valorCarta[8];
            lblPontosJogador.Text = "Pontos Jogador: " + pontosJogador.ToString();

            // Se o jogador não extrapolou a pontuação, habilita a função de pedir mais cartas
            if (pontosJogador < 21)
            {
                btnMaisCarta2.Visible = true;
            }
            else
            {
                revelarCartasBanca();
            }
        }

        private void btnMaisCarta2_Click(object sender, EventArgs e)
        {
            btnMaisCarta2.Visible = false;
            btnOK.Location = new Point(475, 296);


            distribuirCarta9();
            atribuirValorCarta9();
            pontosJogador = valorCarta[6] + valorCarta[7] + valorCarta[8] + valorCarta[9];
            lblPontosJogador.Text = "Pontos Jogador: " + pontosJogador.ToString();

            // Se o jogador não extrapolou a pontuação, habilita a função de pedir mais cartas
            if (pontosJogador < 21)
            {
                btnMaisCarta3.Visible = true;
            }
            else
            {
                revelarCartasBanca();
            }
        }
        private void btnMaisCarta3_Click(object sender, EventArgs e)
        {
            btnMaisCarta3.Visible = false;
            btnOK.Location = new Point(568, 296);

            distribuirCarta10();
            atribuirValorCarta10();
            pontosJogador = valorCarta[6] + valorCarta[7] + valorCarta[8] + valorCarta[9] + valorCarta[10];
            lblPontosJogador.Text = "Pontos Jogador: " + pontosJogador.ToString();

            // Se o jogador não extrapolou a pontuação, habilita a função de pedir mais cartas
            if (pontosJogador < 21)
            {
                btnMaisCarta4.Visible = true;
            }
            else
            {
                revelarCartasBanca();
            }
        }

        private void btnMaisCarta4_Click(object sender, EventArgs e)
        {
            btnMaisCarta4.Visible = false;
            distribuirCarta11();
            atribuirValorCarta11();
            pontosJogador = valorCarta[6] + valorCarta[7] + valorCarta[8] + valorCarta[9] + valorCarta[10] + valorCarta[11];
            lblPontosJogador.Text = "Pontos Jogador: " + pontosJogador.ToString();
            
            // Como esta era a última carta que o jogador poderia pedir, já revela automaticamente o ganhador
            revelarCartasBanca();

        }
        private void btnBlackJack_Click(object sender, EventArgs e)
        {
            // Jogador fez 21 pontos, já revela as cartas e o resultado da partida
            revelarCartasBanca();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // Jogador não quer mais cartas, revela o resultado da partida
            revelarCartasBanca();
        }

        private void revelarCartasBanca()
        {
            // Quando chama esta função, ou o jogador passou de 21 pontos ou ele não quer mais cartas.
            // Será executado esta função para ver quem ganhou o jogo.

            btnOK.Visible = false;
            btnBlackJack.Visible = false;
            btnMaisCarta1.Visible = false;
            btnMaisCarta2.Visible = false;
            btnMaisCarta3.Visible = false;
            btnMaisCarta4.Visible = false;
            
            distribuirCarta1();
            atribuirValorCarta1();
            pontosBanca = valorCarta[0] + valorCarta[1];
            lblPontosBanca.Text = "Pontos banca: " + pontosBanca.ToString();

            if (pontosBanca < 17)
            {
                // Altera a quantidade de cartas da banca para 3, porque assim o As passa a valer 1 ponto
                quantCartasBanca = 3;

                // Como mudou o valor do As, é atribuido os pontos das cartas anteriores novamente
                atribuirValorCarta0();
                atribuirValorCarta1();

                distribuirCarta2();
                atribuirValorCarta2();
                pontosBanca = valorCarta[0] + valorCarta[1] + valorCarta[2];
                lblPontosBanca.Text = "Pontos banca: " + pontosBanca.ToString();
            }

            if (pontosBanca < 17 & quantCartasBanca == 3)
            {
                // Esta ação é executada se a banca está com menos de 17 pontos
                quantCartasBanca = 4;
                distribuirCarta3();
                atribuirValorCarta3();
                pontosBanca = valorCarta[0] + valorCarta[1] + valorCarta[2] + valorCarta[3];
                lblPontosBanca.Text = "Pontos banca: " + pontosBanca.ToString();
            }

            if (pontosBanca < 17 & quantCartasBanca == 4)
            {
                // Esta ação é executada se a banca está com menos de 17 pontos
                quantCartasBanca = 5;
                distribuirCarta4();
                atribuirValorCarta4();
                pontosBanca = valorCarta[0] + valorCarta[1] + valorCarta[2] + valorCarta[3] + valorCarta[4];
                lblPontosBanca.Text = "Pontos banca: " + pontosBanca.ToString();
            }

            if (pontosBanca < 17 & quantCartasBanca == 5)
            {
                // Esta ação é executada se a banca está com menos de 17 pontos
                distribuirCarta5();
                atribuirValorCarta5();
                pontosBanca = valorCarta[0] + valorCarta[1] + valorCarta[2] + valorCarta[3] + valorCarta[4] + valorCarta[5];
                lblPontosBanca.Text = "Pontos banca: " + pontosBanca.ToString();
            }

            // Após fazer todas as ações para revelar as cartas da banca, faz a validação do vencedor
            validacaoVencedor();
            btnNovoJogo.Visible = true;

        }

        private void validacaoVencedor()
        {
            if (pontosBanca > 21 & pontosJogador > 21)
            {
                //Empatou.
                lblResultadoPartida.Text = "EMPATE!!!";
                lblResultadoPartida.Visible = true;
                mostrarPlacares();
            }

             else if (pontosBanca == pontosJogador)
            {
                // Empatou
                lblResultadoPartida.Text = "EMPATE!!!";
                lblResultadoPartida.Visible = true;
                mostrarPlacares();
            }

            if (pontosBanca == 21 & pontosJogador < 21)
            {
                // Banca ganhou
                lblResultadoPartida.Text = "Você PERDEU!!";
                lblResultadoPartida.Visible = true;
                placarBanca = placarBanca + 1;
                mostrarPlacares();
            }

            if (pontosBanca == 21 & pontosJogador > 21)
            {
                // Banca ganhou
                lblResultadoPartida.Text = "Você PERDEU!!";
                lblResultadoPartida.Visible = true;
                placarBanca = placarBanca + 1;
                mostrarPlacares();
            }

            if (pontosJogador == 21 & pontosBanca < 21)
            {
                // Jogador ganhou
                lblResultadoPartida.Text = "Você GANHOU!!";
                lblResultadoPartida.Visible = true;
                placarJogador = placarJogador + 1;
                mostrarPlacares();
            }

            if (pontosJogador == 21 & pontosBanca > 21)
            {
                // Jogador ganhou
                lblResultadoPartida.Text = "Você GANHOU!!";
                lblResultadoPartida.Visible = true;
                placarJogador = placarJogador + 1;
                mostrarPlacares();
            }


            else if (pontosBanca < 21 & pontosJogador > 21)
            {
                // Banca ganhou
                lblResultadoPartida.Text = "Você PERDEU!!";
                lblResultadoPartida.Visible = true;
                placarBanca = placarBanca + 1;
                mostrarPlacares();
            }

            else if (pontosBanca > 21 & pontosJogador < 21)
            {
                // Jogador ganhou
                lblResultadoPartida.Text = "Você GANHOU!!";
                lblResultadoPartida.Visible = true;
                placarJogador = placarJogador + 1;
                mostrarPlacares();
            }

            else if (pontosBanca < 21 & pontosJogador < 21)
            {
                if (pontosBanca > pontosJogador)
                {
                    // Banca Ganhou
                    lblResultadoPartida.Text = "Você PERDEU!!";
                    lblResultadoPartida.Visible = true;
                    placarBanca = placarBanca + 1;
                    mostrarPlacares();
                }
                else if (pontosBanca < pontosJogador)
                {
                    // Jogador ganhou
                    lblResultadoPartida.Text = "Você GANHOU!!";
                    lblResultadoPartida.Visible = true;
                    placarJogador = placarJogador + 1;
                    mostrarPlacares();
                }
      
            }
        }

        private void mostrarPlacares()
        {
            // Mostra o placar geral
            painelPlacar.Visible = true;

            // Aplica o resultado dos placares no label
            lblPlacarBanca.Text = placarBanca.ToString();
            lblPlacarJogador.Text = placarJogador.ToString();
        }


        private void btnNovoJogo_Click(object sender, EventArgs e)
        {
            // Quando clicar no botão novo jogo, tudo será reinicado para uma nova partida
            pct0.Visible = false;
            pct1.Visible = false;
            pct2.Visible = false;
            pct3.Visible = false;
            pct4.Visible = false;
            pct5.Visible = false;
            pct6.Visible = false;
            pct7.Visible = false;
            pct8.Visible = false;
            pct9.Visible = false;
            pct10.Visible = false;
            pct11.Visible = false;

            pontosBanca = 0;
            pontosJogador = 0;
            quantCartasBanca = 2;
            quantCartasJogador = 2;
            carta[0] = 0;
            carta[1] = 0;
            carta[2] = 0;
            carta[3] = 0;
            carta[4] = 0;
            carta[5] = 0;
            carta[6] = 0;
            carta[7] = 0;
            carta[8] = 0;
            carta[9] = 0;
            carta[10] = 0;
            carta[11] = 0;

            lblResultadoPartida.Visible = false;
            lblPontosBanca.Visible = false;
            lblPontosJogador.Visible = false;
            btnNovoJogo.Visible = false;
            btnInicar.Visible = true;
            btnOK.Location = new Point(289, 296);
            lblFundo.Visible = true;
            painelPlacar.Visible = false;
        }

        private void MenuSair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void MenuRegras_Click(object sender, EventArgs e)
        {
            FormRegras formRegras = new FormRegras();

            formRegras.Show();
            
        }
    }
}
