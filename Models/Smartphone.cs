namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        private string _numero;
        private string _modelo;
        private string _imei;
        private int _memoria;
        public string Numero
        {
            get => Numero.ToUpper();

            set
            {
                if (value == "")
                {
                    throw new ArgumentException("Número não pode ser vazio ou nulo.");
                }
                _numero = value;
            }
        }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        private string Modelo
        {
            get => Modelo.ToUpper();

            set
            {
                if (value == "")
                {
                    throw new ArgumentException("Modelo não pode ser vazio ou nulo.");
                }
                _modelo = value;
            }
        }
        private string IMEI
        {
            get => IMEI.ToUpper();

            set
            {
                if (value == "")
                {
                    throw new ArgumentException("IMEI não pode ser vazio ou nulo.");
                }
                _imei = value;
            }
        }
        private int Memoria
        {
            get => Memoria;

            set
            {
                if (value == 0)
                {
                    throw new ArgumentException("Memória não pode ser vazio ou nulo");
                }
                _memoria = value;
            }
        }

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}