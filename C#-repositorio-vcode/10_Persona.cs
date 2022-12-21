
            Persona persona = new Persona();
            persona.Nombre = "Maria";
            persona.Apellido = "De la Hoz";
            persona.Edad = -8;
Console.WriteLine("Persona " + persona.Nombre
                + ", Edad: " + persona.Edad);
                
        public string Nombre;
        public string Apellido;
        //EN LAS PROPIEDADES EXTENDIDAS, QUE SON AQUELLAS 
        //EN LAS QUE DESEAMOS CONTROLAR ALGO
        //SE UTILIZAN CAMPOS PRIVADOS
        private int _Edad;

        public int Edad { 
            get { 
                //SE DEVUELVE EL CAMPO PRIVADO
                return _Edad; 
            }
            set {
                //CAMBIAMOS EL CAMPO PRIVADO
                //COMPROBAMOS EL VALOR QUE VIENE
                if (value < 0) {
                    //LANZAMOS UNA EXCEPCION
                    throw new Exception("La edad no puede ser negativa");
                }
                else
                {
                    _Edad = value;
                }
            }
        }
