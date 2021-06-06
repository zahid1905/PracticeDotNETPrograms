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
     * Conexión a la base de datos
     */
        //public static Connection conn;

        /** 
         * Instancia de la conexión para realizar las consultas a la base de datos
         */
        //public static Statement stmn;

        /**
         * Constructor, aquí se manda a llamar la apertura de la conexión
         */
        public ClientDB()
        {
            openConnection();
        }

        /**
         * Método encargado de realizar la conexión
         */
        public void openConnection()
        {
        }

        /**
         * Método encargado de validar usuarios en la base de datos
         * 
         * @param username nombre del usuario
         * @param password contraseña del usuario
         * @return true si se encontró al usuario, false si no.
         */
        public bool login(String username, String password)
        {
            return false;
        }

        /**
         * Método encargado de crear usuarios
         * 
         * @param username nombre del usuario
         * @param password contraseña del usuario
         * @param permissions un entero que determina los permisos del usuario al 
         * estilo UNIX (valores del 0 al 7)
         * @return true si se pudo crear el usuario, false si no.
         */
        public bool createUser(String username, String password, int permissions)
        {
            return false;
        }

        /**
         * Método encargado de borrar usuarios
         * 
         * @param username nombre del usuario a borrar
         * @return true si se pudo borrar, false si no.
         */
        public bool deleteUser(String username)
        {
            return false;
        }

        /**
         * Método encargado de modificar los permisos de los usuarios
         * @param username nombre del usuario a modificar
         * @param permissions nuevos permisos del usuario
         * @return true si se pudo modificar, false si no.
         */
        public bool changePermissions(String username, int permissions)
        {
            return false;
        }

        /**
         * Método encargado de modificar los permisos de los usuarios
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