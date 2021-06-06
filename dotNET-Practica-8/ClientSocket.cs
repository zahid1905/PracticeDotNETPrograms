using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ftp_server
{
    public class ClientSocket
    {

        //private DataOutputStream messageOut;
        //private DataInputStream messageIn;
        private bool isConnected;
        private bool isinPublic;
        private int permissions;
        private FileManager fm;
        //private Socket client;
        private ClientDB db;

        /**
         * Constructor para la clase ClientSocket, genera los streams de datos
         * para el envío y recepción de mensajes.
         * 
         * @param client
         * @param db 
         */
        /**
        * public ClientSocket(Socket client, ClientDB db)
        * {
        * }
        */

        /**
         * Sobreescritura del método run() de Thread, aquí se verifica
         * la conexión del cliente y se habilita la escucha de mensajes
         */

        public void run()
        {
        }

        /**
         * Método encargado del envío de mensajes, recibe un String
         * que será codificado hacia un byte[] para ser enviado
         * 
         * @param message
         */
        public void sendMessage(String message)
        {
        }

        /**
         *  Método encargado de recibir mensajes, aquí también se verifica
         *  conexión con el cliente
         */
        public void receiveMessage()
        {
        }

        /**
         * Método encargado de recibir archivos y almacenarlos en el servidor
         * 
         * @param filesize
         * @param filename
         * @return boolean true si el archivo fue recibido correctamente, false
         * si ocurrió un error.
         */
        public bool receiveFile(int filesize, String filename)
        {
            return false;
        }

        /**
         * Método encargado de enviar archivos
         * 
         * @param filename
         */
        public void sendFile(String filename)
        {
        }
        /**
         * Método encargado de validar la sesión, utiliza la instancia de 
         * la base de datos que recibe como parámetro la clase ClientSocket.
         * 
         * @param username
         * @param password
         */
        public void loginHandler(String username, String password)
        {
        }

        /**
         * Método encargado de registrar un nuevo usuario
         * 
         * @param username
         * @param password
         * @param permission
         */
        public void registerHandler(String username, String password, int permission)
        {
        }

        /**
         * Método encargado de actualizar los permisos del usuario
         * 
         * @param username
         * @param permission
         */
        public void updateHandler(String username, int permission)
        {
        }

        /**
         * Método encargado de eliminar a un usuario
         * 
         * @param username
         */
        public void deleteHandler(String username)
        {
        }

        /**
         * Método encargado de manejar las peticiones del cliente, aquí se
         * determina la petición del usuario y se determina la acción que 
         * el servidor realizará.
         * 
         * @param petition
         */
        public void petitionHandler(String petition)
        {
        }
    }
}
    