using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ftp_server
{
    class ClientDB
    {
        /**
     * Conexi�n a la base de datos
     */
        //public static Connection conn;

        /** 
         * Instancia de la conexi�n para realizar las consultas a la base de datos
         */
        //public static Statement stmn;

        /**
         * Constructor, aqu� se manda a llamar la apertura de la conexi�n
         */
        public ClientDB()
        {
            openConnection();
        }

        /**
         * M�todo encargado de realizar la conexi�n
         */
        public void openConnection()
        {
        }

        /**
         * M�todo encargado de validar usuarios en la base de datos
         * 
         * @param username nombre del usuario
         * @param password contrase�a del usuario
         * @return true si se encontr� al usuario, false si no.
         */
        public bool login(String username, String password)
        {
            return false;
        }

        /**
         * M�todo encargado de crear usuarios
         * 
         * @param username nombre del usuario
         * @param password contrase�a del usuario
         * @param permissions un entero que determina los permisos del usuario al 
         * estilo UNIX (valores del 0 al 7)
         * @return true si se pudo crear el usuario, false si no.
         */
        public bool createUser(String username, String password, int permissions)
        {
            return false;
        }

        /**
         * M�todo encargado de borrar usuarios
         * 
         * @param username nombre del usuario a borrar
         * @return true si se pudo borrar, false si no.
         */
        public bool deleteUser(String username)
        {
            return false;
        }

        /**
         * M�todo encargado de modificar los permisos de los usuarios
         * @param username nombre del usuario a modificar
         * @param permissions nuevos permisos del usuario
         * @return true si se pudo modificar, false si no.
         */
        public bool changePermissions(String username, int permissions)
        {
            return false;
        }

        /**
         * M�todo encargado de modificar los permisos de los usuarios
         * @param username nombre del usuario a modificar
         * @param permissions nuevos permisos del usuario
         * @return true si se pudo modificar, false si no.
         */
        public int checkPermissions(String username)
        {
            return 0;
        }
    }
}