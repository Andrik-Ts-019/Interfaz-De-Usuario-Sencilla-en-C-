using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class Metodos
    {
        public bool NoPuntosSeguidos(string verificar,List<char> alfabeto)
        {
            int PosicionDePunto=0;

            for(PosicionDePunto=0;PosicionDePunto<alfabeto.Count;PosicionDePunto++)
            {
                if(alfabeto[PosicionDePunto].Equals('.'))
                {
                    break;
                }
            }

            for(int i=0;i<verificar.Length;i++)
            {
                try
                {
                    if (verificar[i].Equals(alfabeto[PosicionDePunto]))
                    {
                        if (verificar[i + 1].Equals('.'))
                        {
                            return false;
                        }
                    }
                }
                catch (System.IndexOutOfRangeException) { continue; };
            }
            return true;
        }

        public bool ElFinalDeLaCadena(string verificar,string matricula,List<char> alfabeto)
        {
            //Construimos una cadena que tenga ".Matricula" para despues buscarla en nuestra cadena a verificar
            string subcadenaFinal=".";
            for(int i=0;i<matricula.Length;i++)
            {
                subcadenaFinal = subcadenaFinal.Insert(i + 1, matricula[i].ToString());
            }

            if(verificar.Length>=subcadenaFinal.Length)
            {
                int puntodePartida,contadorSubCadena=0;

                puntodePartida = verificar.Length - subcadenaFinal.Length;
                Console.WriteLine("PUNTO DE PARTIDA:" + puntodePartida);
                for(int i=puntodePartida;i<verificar.Length;i++)
                {
                    if(subcadenaFinal[contadorSubCadena].Equals(verificar[i]))
                    {
                        Console.WriteLine("SUBCADENA FIN:"+subcadenaFinal[contadorSubCadena]+"  Cadena ingresada:"+verificar[i]+" MI i:"+i);
                        contadorSubCadena += 1;
                    }

                }

                if (subcadenaFinal.Length == contadorSubCadena)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }                      
        }

        public bool ContieneTodasLasIniciales(string nombre,string cadenaAverificar)
        {
            //Creamos una cadena para guardar las iniciales de nuestro nombre
            string iniciales = "";

            //llenamos la primera posicion de la cadena inicial con el primer caracter
            //de la cadena a verificar
            int agregar = 0;
            try
            {
                iniciales = iniciales.Insert(agregar, nombre[0].ToString());
            }catch (System.IndexOutOfRangeException){}
           
            for (int i = 0; i < nombre.Length;i++)
            {                
                if (nombre[i].Equals(' '))
                {
                    try
                    {
                        agregar += 1;
                        iniciales = iniciales.Insert(agregar, nombre[i+1].ToString());                      
                    }catch (System.IndexOutOfRangeException) { continue; }                                   
                }
            }

            bool buscarInicialesEnCadena = cadenaAverificar.Contains(iniciales);            
            return buscarInicialesEnCadena;
        }

        public bool PrimerSimboloDigito(List<char> alfabeto,string cadenaAverificar)
        {
            int cont = 0, cont2 = 0;
            List<int> numeros = new List<int>();
          
            //Creamos una lista para guardar los numeros que permitira nuestro automata
            for(int i=0;i<alfabeto.Count;i++)
            {
                try
                {
                    if (Char.IsNumber(alfabeto[i]))
                    {
                        numeros.Add(alfabeto[i]);
                    }
                } catch (System.ArgumentOutOfRangeException) {continue;}
            }
            
            //Verificamos si nuestro primer caracter ingresado es un numero dentro de nuestro alfabeto

            //Si la cadena que voy a comprobar es vacia no se ejecutan las acciones
            if(!(cadenaAverificar.Length==0))
            {
                for (int i = 0; i < numeros.Count; i++)
                {
                    try
                    {
                        //saber si mi elemento 0 de mi cadena a verificar tiene al menos un numero de mi lista de numeros
                        if (numeros[i].Equals(cadenaAverificar[0]))
                        {
                            return true;
                        }
                        else
                        {
                            cont += 1;
                        }

                        //Saber si mi cadena a verificar tiene letras en la primera posicion o si es vacia
                        if (cadenaAverificar[0] < 48 || cadenaAverificar[0] > 57)
                        {
                            cont2 += 1;
                        }
                    }
                    catch (System.IndexOutOfRangeException) { continue; }
                }
            }
            else
            {
                cont2 = cont2 + 1;
            }
                  
            //Si no es numero
            if(cont2>0||numeros.Count==cont)
            {
                return false;              
            }                      
            return false;
        }

        public string AlfabetoVisible(List<char> alfabeto)
        {
            int i, insertComa = 1, insertNum = 0;
            string AlfabetoVisible = "";

            //For para crear una cadena visible en el label
            for (i = 0; i < alfabeto.Count; i++)
            {
                try
                {
                    if (i == alfabeto.Count - 1)
                    {
                        AlfabetoVisible = AlfabetoVisible.Insert(insertNum, alfabeto[i].ToString());
                    }
                    else
                    {
                        AlfabetoVisible = AlfabetoVisible.Insert(insertNum, alfabeto[i].ToString());
                        insertNum += 2;

                        AlfabetoVisible = AlfabetoVisible.Insert(insertComa, ",");
                        insertComa += 2;
                    }

                }
                catch (System.ArgumentOutOfRangeException) { continue; }
            }

            return AlfabetoVisible;
        }

        public List<char> EliminarRepetidos(List<char> alfabeto)
        {
            for (int i = 0; i < alfabeto.Count; i++)
            {
                for (int j = i + 1; j < alfabeto.Count; j++)
                {
                    try
                    {
                        if (alfabeto[i].Equals(alfabeto[j]))
                        {
                            alfabeto.RemoveAt(j);
                            EliminarRepetidos(alfabeto);
                        }
                    }
                    catch (System.ArgumentOutOfRangeException) { continue; }
                }
            }
            return alfabeto;
        }

        public List<char> ObtenerAlfabeto(List<char> alfabeto)
        {
            alfabeto = EliminarRepetidos(alfabeto);
            return alfabeto;
        }

        //Esta funcion me dice si cada elemento de mi cadena pertenece al alfabeto
        public bool EnAlfabeto(string verificar,List<char> alfabeto)
        {
            int cont = 0;
            
            if(verificar.Length==0)
            {
                MessageBox.Show("USTED NO INGRESO NADA");
                return false;
            }
            else
            {
                for (int i = 0; i < verificar.Length; i++)
                {
                    for (int j = 0; j < alfabeto.Count; j++)
                    {
                        if (alfabeto[j].Equals(verificar[i]))
                        {                          
                            cont += 1;
                        }
                    }
                }
            }

            if(cont==verificar.Length)
            {
                //MessageBox.Show("LA CADENA INGRESADA ES CORRECTA");
                return true;
            }
            else
            {
                //MessageBox.Show("LA CADENA INGRESADA ES INCORRECTA(TIENES COSAS QUE NO SON DEL ALFABETO)");
                return false;
            }       
        }
    }
}
