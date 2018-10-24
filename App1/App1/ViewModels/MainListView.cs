using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace App1.ViewModels
{
    public class MainListView
    {
        private Pregunta _oldProduct;
        public ObservableCollection<Pregunta> Preguntas { get; set; }



        public MainListView()
        {
            Preguntas = new ObservableCollection<Pregunta>
            {
                new Pregunta
                {
                    Title = "¿Dónde puedo pagar?",
                    Isvisible =false,
                    Respuesta = "En cualquier sucursal bancaria de City Banamex, al número de cuenta: 7010-4612812."
                },
                new Pregunta
                {
                    Title = "¿Cuáles son los costos?",
                    Isvisible = false,
                    Respuesta = "Inscripción   $400 " + "\r\n"+
                    "Mensualidad   $750" +"\r\n"+
                    "Re-inscripción   $50" +"\r\n"+
                    "Transporte (boleto con 5 viajes)   $10" +"\r\n"+
                    "Playera Institucional   $150" +"\r\n"+
                    "Materia de Repetición   $500" +"\r\n"+
                    "Constancia de Estudios   $50" +"\r\n"+
                    "Kardex Simple   $50" +"\r\n"+
                    "Reposición de credencial   $150" +"\r\n"+
                    "Constancia de Competencias   $500" +"\r\n"+
                    "Revalidación de materia   $250" +"\r\n"+
                    "Titulación   $5,500"
                },
                new Pregunta
                {
                    Title = "¿Cómo realizo un tramite?",
                    Isvisible = false,
                    Respuesta = "Para cualquier trámite a realizar es necesario traer el recibo del banco con el " +
                    "CP.José Luis Narváez y entregar la ficha en el Dpto. de Escolar y Archivo."
                },
                new Pregunta
                {
                    Title = "¿Cuáles son las fechas límites de los pagos?",
                    Isvisible =  false,
                    Respuesta = "Mensualidad:" +"\r\n"+
                    "Dependiendo de tu plan de pagos que aparece en el SII." +"\r\n"+"\r\n"+
                    "Re-inscripción:" +"\r\n"+
                    "Durante la semana de reinscripciones de la UPAP." +"\r\n"+"\r\n"+
                    "Materia de Repetición:" +"\r\n"+
                    "Antes de que se termine el cuatrimestre."
                },
                new Pregunta
                {
                    Title = "¿Qué rutas de camión pasa por la UPAP?",
                    Isvisible = false,
                    Respuesta= "R-104.- Dr. Gonzalez" +"\r\n"+
                    "R-104.- Las Haciendas" +"\r\n"+
                    "R-104.- Las haciendas – Apodaca" +"\r\n"+
                    "R-104.- Marín – Higueras" +"\r\n"+
                    "R-104.- Marín – Higueras – Directo" +"\r\n"+
                    "R-104.- Marín – Zuazua" +"\r\n"+
                    "R-104.- Real de palmas" +"\r\n"+
                    "R-104.- Real del sol" +"\r\n"+
                    "R-104.- Venadera" +"\r\n"+
                    "R-111.- Arena – KIA" +"\r\n"+
                    "R-111.- Ejido Santa María" +"\r\n"+
                    "R-111.- Los Ramones" +"\r\n"+
                    "R-111.- Pesquería Directo" +"\r\n"+
                    "R-111.- Real de palmas" +"\r\n"+
                    "R-111.- Real del sol" +"\r\n"+
                    "R-111.- Zacatecas" +"\r\n"+
                    "R-111.- Zuazua"
                },
                new Pregunta
                {
                    Title = "¿Dónde compro los boletos del transporte?",
                    Isvisible =false,
                    Respuesta = "Directamente con el chofer en turno."
                },
                new Pregunta
                {
                    Title = "¿Qué horarios tiene el transporte escolar?",
                    Isvisible =false,
                    Respuesta = "Centro de Apodaca(plaza) - UPAP" +"\r\n"+
                    "6:15 – 6:30" +"\r\n"+
                    "6:50 – 7:10" +"\r\n"+
                    "7:30 – 8:00" +"\r\n"+
                    "8:30 – 9:00" +"\r\n"+
                    "12:30 – 13:00" +"\r\n"+
                    "13:30 – 14:00" +"\r\n"+
                    "14:15 – 14:40"
                }
            };
        }
        public void ShoworHiddenProducts(Pregunta pregunta)
        {
            if (_oldProduct == pregunta)
            {
                pregunta.Isvisible = !pregunta.Isvisible;
                UpDateProducts(pregunta);
            }
            else
            {
                if (_oldProduct != null)
                {
                    _oldProduct.Isvisible = false;
                    UpDateProducts(_oldProduct);

                }
                pregunta.Isvisible = true;
                UpDateProducts(pregunta);
            }
            _oldProduct = pregunta;
        }

        private void UpDateProducts(Pregunta pregunta)
        {

            var Index = Preguntas.IndexOf(pregunta);
            Preguntas.Remove(pregunta);
            Preguntas.Insert(Index, pregunta);

        }
    }
}
