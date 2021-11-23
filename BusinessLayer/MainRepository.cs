using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public sealed class MainRepository
    {

        public static MainRepository Instance { get; } = new MainRepository();

        #region "User"

        public int? UserIdex = null;

        public int UserType = 0;

        #endregion

        #region "Doctor"

        public int? DoctorIndex = null;

        public string fileNameD = null; //Direccion de Archivo en el Ordenador

        public string destinationD = null; //Directorio y Nombre imagen, copiada en el Programa

        #endregion

        #region "Patient"

        public int? PatientIndex = null;

        public string fileNameP = null; 

        public string destinationP = null;

        #endregion

        #region "Lab"

        public int? LabIndex = null;

        #endregion

        private MainRepository()
        {

        }
    }
}
