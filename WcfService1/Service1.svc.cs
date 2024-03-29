﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IService1
    {
        public string GetData(int edad)
        {
            
            string msj;
            if(edad >= 1 && edad <=18)
            {
                msj = "edad admitida para votar" + edad;
            }
            else if(edad >= 19 && edad <= 60)
            {
                msj = "puede votar si deseas  "+edad;
            }
            else if(edad >= 60 && edad <= 100)
            {
                msj = "ya no puede votar"+edad;
            }
            else
            {
                msj = "edad erronea no se puede admitir " +edad;
            }
            return msj; 


            
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
