using OpenTK;
using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace openTK3D
{
    public partial class OpenTK3D : Form
    {
        int lateral = 0;
        Vector3d dir = new Vector3d(0, -450, 170);        //direção da câmera
        Vector3d pos = new Vector3d(0, -550, 170);     //posiçãoo da câmera
        float camera_rotation = 0;                     //rotação no eixo Z

        int lado = 3;
        int altura = 20;
        int comprimento = 20;


        public OpenTK3D()
        {
            InitializeComponent();
        }

        private void glControl1_Paint(object sender, PaintEventArgs e)
        {

            glControl1.MakeCurrent();
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit); //limpa os buffers
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadIdentity(); //zera a matriz de projeção com a matriz identidade

            Matrix4d lookat = Matrix4d.LookAt(pos.X, pos.Y, pos.Z, dir.X, dir.Y, dir.Z, 0, 0, 1);

            //aplica a transformacao na matriz de rotacao
            GL.LoadMatrix(ref lookat);

            GL.Enable(EnableCap.DepthTest);

            //EIXOS X, Y, Z
            GL.Begin(PrimitiveType.Lines);
            GL.Color3(Color.Red);
            GL.Vertex3(0, 0, 0); GL.Vertex3(500, 0, 0);
            GL.Color3(Color.Blue);
            GL.Vertex3(0, 0, 0); GL.Vertex3(0, 500, 0);
            GL.Color3(Color.Green);
            GL.Vertex3(0, 0, 0); GL.Vertex3(0, 0, 500);
            GL.End();

            //desenhaCubo(100);
            desenhaPoligono(lado, altura, comprimento);

            glControl1.SwapBuffers(); //troca os buffers de frente e de fundo 

        }

        private void desenhaPiramide(int lados, int altura, int comprimento)
        {
            int radius = comprimento;
            float n = 360 / lados;

            GL.Clear(ClearBufferMask.ColorBufferBit);
            GL.Color3(Color.White);
            GL.Begin(PrimitiveType.Triangles);
            for (float i = 0; i < 360; i += n)
            {
                double degInRad = i * (3.1416 / 180);
                GL.Color3(Color.Red);
                GL.Vertex3(Math.Cos(degInRad) * radius, Math.Sin(degInRad) * radius, 0);
                GL.Color3(Color.Blue);
                GL.Vertex3(0, 0, 0);
                float d = i + n;
                degInRad = d * (3.1416 / 180);
                GL.Color3(Color.Green);
                GL.Vertex3(Math.Cos(degInRad) * radius, Math.Sin(degInRad) * radius, 0);

            }
            GL.End();

            GL.Color3(Color.White);
            GL.Begin(PrimitiveType.Triangles);
            for (float i = 0; i < 360; i += n)
            {
                double degInRad = i * (3.1416 / 180);
                GL.Color3(Color.Red);
                GL.Vertex3(Math.Cos(degInRad) * radius, Math.Sin(degInRad) * radius, 0);
                GL.Color3(Color.Blue);
                GL.Vertex3(0, 0, altura);
                float d = i + n;
                degInRad = d * (3.1416 / 180);
                GL.Color3(Color.Green);
                GL.Vertex3(Math.Cos(degInRad) * radius, Math.Sin(degInRad) * radius, 0);

            }
            GL.End();

        }

        private void desenhaPoligono(int lados, int altura, int comprimento)
        {

            int radius = comprimento;
            float n = 360 / lados;

            GL.Clear(ClearBufferMask.ColorBufferBit);
            GL.Color3(Color.White);
            GL.Begin(PrimitiveType.Triangles);
            for (float i = 0; i < 360; i += n)
            {
                double degInRad = i * (3.1416 / 180);
                GL.Color3(Color.Red);
                GL.Vertex3(Math.Cos(degInRad) * radius, Math.Sin(degInRad) * radius, 0);
                GL.Color3(Color.Blue);
                GL.Vertex3(0, 0, 0);
                float d = i + n;
                degInRad = d * (3.1416 / 180);
                GL.Color3(Color.Green);
                GL.Vertex3(Math.Cos(degInRad) * radius, Math.Sin(degInRad) * radius, 0);

            }
            GL.End();

            GL.Color3(Color.White);
            GL.Begin(PrimitiveType.Triangles);
            for (float i = 0; i < 360; i += n)
            {
                double degInRad = i * (3.1416 / 180);
                GL.Color3(Color.Red);
                GL.Vertex3(Math.Cos(degInRad) * radius, Math.Sin(degInRad) * radius, altura);
                GL.Color3(Color.Blue);
                GL.Vertex3(0, 0, altura);
                float d = i + n;
                degInRad = d * (3.1416 / 180);
                GL.Color3(Color.Green);
                GL.Vertex3(Math.Cos(degInRad) * radius, Math.Sin(degInRad) * radius, altura);

            }
            GL.End();

            for (float i = 0; i < 360; i += n)
            {
                GL.Color3(Color.White);
                GL.Begin(PrimitiveType.Triangles);
                double degInRad = i * (3.1416 / 180);
                GL.Color3(Color.Red);
                GL.Vertex3(Math.Cos(degInRad) * radius, Math.Sin(degInRad) * radius, altura);
                GL.Color3(Color.Blue);
                GL.Vertex3(Math.Cos(degInRad) * radius, Math.Sin(degInRad) * radius, 0);
                float d = i + n;
                degInRad = d * (3.1416 / 180);
                GL.Color3(Color.Green);
                GL.Vertex3(Math.Cos(degInRad) * radius, Math.Sin(degInRad) * radius, altura);
                GL.End();

                GL.Color3(Color.White);
                GL.Begin(PrimitiveType.Triangles);
                degInRad = i * (3.1416 / 180);
                GL.Color3(Color.Red);
                GL.Vertex3(Math.Cos(degInRad) * radius, Math.Sin(degInRad) * radius, 0);
                d = i + n;
                degInRad = d * (3.1416 / 180);
                GL.Color3(Color.Blue);
                GL.Vertex3(Math.Cos(degInRad) * radius, Math.Sin(degInRad) * radius, altura);
                GL.Color3(Color.Green);
                GL.Vertex3(Math.Cos(degInRad) * radius, Math.Sin(degInRad) * radius, 0);
                GL.End();


            }

        }
    

        private void desenhaCubo(double lado)
        {
            Vector3d[] v = { new Vector3d(lado, -lado, -lado),
                             new Vector3d(lado, lado, -lado),
                             new Vector3d(-lado, lado, -lado),
                             new Vector3d(-lado,-lado,-lado),
                             new Vector3d(lado, -lado, lado),
                             new Vector3d(lado,lado,lado),
                             new Vector3d(-lado, lado, lado),
                             new Vector3d(-lado,-lado,lado)
            };

            desenhaLado(v[0], v[3], v[2], v[1]); //abaixo
            desenhaLado(v[4], v[5], v[6], v[7]); //acima
            desenhaLado(v[0], v[1], v[5], v[4]); //direita
            desenhaLado(v[2], v[3], v[7], v[6]); //esquerda
            desenhaLado(v[1], v[2], v[6], v[5]); //fundo
            desenhaLado(v[0], v[4], v[7], v[3]); //frente
        }
        private void desenhaLado(Vector3d v1, Vector3d v2, Vector3d v3, Vector3d v4)
        {
            GL.Begin(PrimitiveType.Triangles);
            GL.Color3(Color.AliceBlue); 
            GL.Vertex3(v1);
            GL.Color3(Color.Blue);
            GL.Vertex3(v2);
            GL.Color3(Color.Green);
            GL.Vertex3(v3);

            GL.Color3(Color.AliceBlue);
            GL.Vertex3(v1);
            GL.Color3(Color.Blue);
            GL.Vertex3(v3);
            GL.Color3(Color.Green);
            GL.Vertex3(v4);

            GL.End();
        }

        private void glControl1_Load(object sender, EventArgs e)
        {
            GL.ClearColor(Color.Black);         // definindo a cor de limpeza do fundo da tela
            GL.Enable(EnableCap.Light0);

            SetupViewport(glControl1);                      //configura a janela de pintura
        }

        private void SetupViewport(GLControl janela) //configura a janela de projeção 
        {
            int w = janela.Width; //largura da janela
            int h = janela.Height; //altura da janela

            Matrix4 projection = Matrix4.CreatePerspectiveFieldOfView(1.0f, w / (float)h, 1.0f, 2000.0f);


            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity(); //zera a matriz de projeção com a matriz identidade

            GL.LoadMatrix(ref projection);

            GL.Viewport(0, 0, w, h); // usa toda area de pintura da glcontrol
            lateral = w / 2;

        }


        private void calcula_direcao()
        {
            dir.X = pos.X + (Math.Sin(camera_rotation * Math.PI / 180) * 100);
            dir.Y = pos.Y + (Math.Cos(camera_rotation * Math.PI / 180) * 100);
        }
        private void glControl1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.X > lateral)
            {
                camera_rotation += 2;
            }
            if (e.X < lateral)
            {
                camera_rotation -= 2;
            }
            lateral = e.X;
            calcula_direcao();
            glControl1.Invalidate();
            glControl2.Invalidate();
        }

        private void glControl1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            float a = camera_rotation;
            int tipoTecla = 0;
            if (e.KeyCode == Keys.A)
            {
                a -= 90;
                tipoTecla = 1;
            }
            if (e.KeyCode == Keys.D)
            {
                a += 90;
                tipoTecla = 1;
            }
            if (e.KeyCode == Keys.W)
            { tipoTecla = 1; }
            if (e.KeyCode == Keys.S)
            {
                a += 180;
                tipoTecla = 1;
            }

            if (e.KeyCode == Keys.E)
            {
                a += 1;
                tipoTecla = 2;
            }
            if (e.KeyCode == Keys.Q)
            {
                a -= 1;
                tipoTecla = 2;
            }
            if (tipoTecla == 1)
            {
                if (a < 0) a += 360;
                if (a > 360) a -= 360;
                pos.X += (Math.Sin(a * Math.PI / 180) * 10);
                pos.Y += (Math.Cos(a * Math.PI / 180) * 10);
                calcula_direcao();
                glControl1.Invalidate();
                glControl2.Invalidate();
            }

            if (tipoTecla == 2)
            {
                camera_rotation = a;
                calcula_direcao();
                glControl1.Invalidate();
                glControl2.Invalidate();
            }
        }

        static int LoadTexture(string filename)
        {
            if (String.IsNullOrEmpty(filename))
                throw new ArgumentException(filename);

            int id;//= GL.GenTexture(); 

            GL.GenTextures(1, out id);
            GL.BindTexture(TextureTarget.Texture2D, id);

            Bitmap bmp = new Bitmap(filename);

            BitmapData data = bmp.LockBits(new System.Drawing.Rectangle(0, 0, bmp.Width, bmp.Height),
                ImageLockMode.ReadOnly, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

            GL.TexImage2D(TextureTarget.Texture2D, 0, PixelInternalFormat.Rgba, data.Width, data.Height, 0,
                OpenTK.Graphics.OpenGL.PixelFormat.Bgra, PixelType.UnsignedByte, data.Scan0);
            bmp.UnlockBits(data);

            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMinFilter, (int)TextureMinFilter.Linear);
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMagFilter, (int)TextureMagFilter.Linear);
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureWrapS, (int)TextureWrapMode.Repeat);
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureWrapT, (int)TextureWrapMode.Repeat);

            return id;
        }

        private void glControl2_Load(object sender, EventArgs e)
        {
            GL.ClearColor(Color.Black);         // definindo a cor de limpeza do fundo da tela
            GL.Enable(EnableCap.Light0);
            SetupViewport(glControl2);
        }

        private void glControl2_Paint(object sender, PaintEventArgs e)
        {
            glControl2.MakeCurrent();
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit); //limpa os buffers
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadIdentity(); //zera a matriz de projeção com a matriz identidade

            Matrix4d lookat = Matrix4d.LookAt(pos.X, pos.Y, pos.Z, dir.X, dir.Y, dir.Z, 0, 0, 1);

            //aplica a transformacao na matriz de rotacao
            GL.LoadMatrix(ref lookat);

            GL.Enable(EnableCap.DepthTest);

            //EIXOS X, Y, Z
            GL.Begin(PrimitiveType.Lines);
            GL.Color3(Color.Red);
            GL.Vertex3(0, 0, 0); GL.Vertex3(500, 0, 0);
            GL.Color3(Color.Blue);
            GL.Vertex3(0, 0, 0); GL.Vertex3(0, 500, 0);
            GL.Color3(Color.Green);
            GL.Vertex3(0, 0, 0); GL.Vertex3(0, 0, 500);
            GL.End();

            //desenhaCubo(100);
            desenhaPiramide(lado, altura, comprimento);


            glControl2.SwapBuffers(); //troca os buffers de frente e de fundo 

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int.TryParse(EntradaLados.Value.ToString(), out lado);
                int.TryParse(EntradaAltura.Value.ToString(), out altura);
                int.TryParse(EntradaComprimento.Value.ToString(), out comprimento);

            }
            catch { MessageBox.Show("Não deu certo"); }

        }
    }
}
