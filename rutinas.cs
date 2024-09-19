using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GestionDeServicios
{
    class rutinas
    {
        //arreglos de los campos de cada ficha 
        private string[] tabPermiso;
        private string[] tabPredio;
        private string[] tabCuantif;
        private string[] tabfiniq;
        private string[] tabStats;

        public string[] TabPermiso { get => tabPermiso; set => tabPermiso = value; }
        public string[] TabPredio { get => tabPredio; set => tabPredio = value; }
        public string[] TabCuantif { get => tabCuantif; set => tabCuantif = value; }
        public string[] Tabfiniq { get => tabfiniq; set => tabfiniq = value; }
        public string[] TabStats { get => tabStats; set => tabStats = value; }


        //valores en default en caso de campos vacios
        public rutinas() 
        {
            tabPermiso = new string[25];
            tabPredio = new string[5];
            tabCuantif = new string[16];
            tabfiniq = new string[6];
            tabStats = new string[17];
        }

        //extrae todo de la interfaz de capturas
        public rutinas(string[] tabPermiso, string[] tabPredio, string[] tabCuantif, string[] tabfiniq)
        {
            this.tabPermiso = tabPermiso;
            this.tabPredio = tabPredio;
            this.tabCuantif = tabCuantif;
            this.tabfiniq = tabfiniq;
            //this.tabStats = tabStats;
        }

   
        public bool ValidaTab1()
        {
            /*
            //FOLIO NCHAR 10 NOT NULL[PK]
            if (tabPermiso[0] == "")
                return false;
            else if (tabPermiso[0].Length > 10)
                return false;
            */

            return true;
        }

        public bool ValidaTab4()
        {
            return true;
        }



        /*PERMISO DE PASO [SE GUARDA EN TABLA PERMISO PERMISO]
            
            BLOQUE      NCHAR 50 NULL
            FECHA       FECHA VALIDA NULL
            GESTOR      NCHAR 50 NULL

             DATOS DEL PROPIETARIO
               nombre   NORMAL 50 NULL
               curp     NORMAL 50 NULL
               rfc      NORMAL 50 NULL
               Tipo Propietario NORMAL  50 NULL  valores en: Propietario, Arrendador, ejidatario. [SE GUARDA TAMBIEN EN CATTIPOPROPIETARIO]
               direccion        NORMAL  150 NULL 
               Municipio        NORMAL  50 null  [CATMUNICIPIO]
               estado           NORMAL  50 null  [CATESTADO]
               CP               NORMAL  10 null
               Tel fijo         NORMAL  10 null
               tel movil        NORMAL  10 null
               Apoderado legal  NORMAL  50 NULL       
               DocIdf valores en: INE, PASAPORTE, LICENCIA DE CONDUCIR, ETC. [CATIDENTIFICACION]
            
            DATOS DEL PREDIO
                Nombre              NORMAL 50 null
                Doc Propiedad       NORMAL 50 null [CATDOCACREDITACION]
                Cultivos            NORMAL 50 null
                Superficie          EN HECTAREAS/NUMERICO
                Numero de Parcela   NORMAL
                Municipio           NORMAL [CATMUNICIPIO]
                Estado              NORMAL [CATESTADO]
                Ubicación/Comunidad NORMAL [SE GUARDA TAMBIEN EN CATCOMUNIDAD]
                Observaciones       NORMAL max null
             */




        //ESTA FUNCION MANDA UN MENSAJE EN "CAPTURAEDICION"
        public void Validar()
        {
            //SI LOS DATOS SON VALIDOS DE ACUERDO A LOS REQUISITOS
        
            
        }


        /*DELIMITACION DEL PREDIO [SE GUARDA EN DELIMITACION]
            FOLIO NCHAR 10 PK, FK CON PERMISO NO NULL              
            Fecha                   NO VACIO
            Delimitador             NO VACIO
            Colindancias y medidas  NO VACIO
            Observaciones           NO VACIO
            TIENE OTROS DATOS NO NULL QUE SON?    

            [SE GUARDA EN TABLA: COORDENADAS PREDIO]
            FOLIO       NCHAR 10, PK NO NULL
            CoordX      NORMAL NUMERICO
            CoordY      NORMAL NUMERICO
            NUM         NORMAL NUMERICO
         */


        /*CUANTIFICACION DE AFECTACIONES
                [SE GUARDA EN CUANTIFICACION]
                Folio       NCHAR 10 PK NO NULL   [CUANTIFICACION, DESGLOSEAFECTACION]
                Fecha       NORMAL
                Valuador    NORMAL
                Finiquito   NUMERICO
                Observaciones NORMAL

                 [SE GUARDA EN TABLA LINEAS SIN AFECTACION]
                TIPO AFECTACION: NO NULL   Valores permitidos: Linea fuente, Linea receptora, 
                                            Acceso Fuente, Acceso Receptora, Ampliacion, Area de pruebAS
                FECHA         NORMAL 
                LINEA         NUMERICO
                STK INI       NUMERICO
                INI+          NUMERICO
                STK FIN       NUMERICO
                FIN+          NUMERICO
                CONCEPTO      NORMAL

                [SE GUARDA EN TABULADOR]
                TARIFA NUMERICO

                [SE GUARDA EN DESGLOSE AFECTACION]            
                Calculo por árbol       NORMAL
                %de Afectación          NUMERICO
                Tipo de afectación      NULL MENCIONADO [CATTIPOAFECTACION]
                Linea                   NUMERICO
                STK INI                 NUMERICO
                INI+                    NUMERICO
                STK FIN                 NUMERICO
                FIN+                    NUMERICO
                ID                      NORMAL   [TABULADOR, CATTIPOAFECTACION]
                CONCEPTO                NORMAL   [TABULADOR]

                
                PRECIOXHA               NUMERICO (DATADAGRID)
                ANCHO(M)                DECIMAL (DATADAGRID)
                KMS                     NORMAL (DATADAGRID)
                AREATOTAL               NUMERICO (DATADAGRID)
                MONTO TOTAL             NUMERICO (DATADAGRID)
             */

        /* DATOS DEL FINIQUITO [SE GUARDA EN LA TABLA FINIQUITO]
            FOLIO                   NUMERICO NO NULO  
            No de Cheque            NUMERICO
            Fecha                   FECHA VALIDA
            Fecha de cheque         FECHA VALIDA
            Fecha de pago           FECHA VALIDA
            Observaciones           NORMAL
        */



    }
}