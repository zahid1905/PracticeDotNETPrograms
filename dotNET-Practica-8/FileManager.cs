using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ftp_server
{
    class FileManager
    {
        /**
        * String que determina el directorio público para todos los usuarios
        */
        public String publicPath = "/Users/mauricioic/Documents/server/public/";
    
        /**
        * String que determina el directorio raíz del servidor FTP
        */
        public String rootPath = "/Users/mauricioic/Documents/server/";
    
        /**
         * String que almacenará el directorio personal del usuario
        */
        public String personalPath;

        /**
        * String que almacenará el directorio actual del usuario
        */
        public String currentDirectory;

        /**
        * Constructor
        * 
        * @param username nombre del usuario para determinar el directorio
        */
        public FileManager(String username)
        {
            this.personalPath = this.rootPath + username;
            this.currentDirectory = personalPath;
        }

        /**
        * Método para cambiar al directorio público.
        */
        public void goToPublicDirectory()
        {
            this.currentDirectory = publicPath;
        }

        /**
         * Método para cambiar al directorio personal.
         */
        public void goToPersonalDirectory()
        {
            this.currentDirectory = personalPath;
        }

        /**
         * Método encargado de bajar un nivel en la navegación de directorios
         * 
         * @param newPath directorio al que se quiere navegar
         * @return String que contiene el directorio actual
         */
        public String changeDirectory(String newPath)
        {
            return this.currentDirectory;
        }

        /**
         * Método encargado de subir un nivel en la navegación de directorios
         * 
         * @return String que contiene el directorio actual
         */
        public String changeDirectory()
        {
            return this.currentDirectory;
        }

        /**
         * Método encargado de retornar el directorio actual de la instancia
         * 
         * @return String que contiene el directorio actual
         */
        public String getCurrentDirectory()
        {
            return this.currentDirectory;
        }

        /**
         * Método encargado de retornar los archivos y subdirectorios de un directorio
         * 
         * @param r bandera que indica si se listarán los archivos o los archivos y 
         * directorios
         * @return la lista de archivos en un String
         */
        public String getFiles(bool r)
        {
            return "";
        }

        /**
         * Método encargado de retornar el nombre del archivo
         * 
         * @param filename nombre del archivo del cuál se quieren obtener los datos
         * @return el nombre de un archivo en String
         */
        public String getFileName(String filename)
        {
            return "";
        }

        /**
         * Método para crear un directorio
         * 
         * @param dirname nombre del directorio que se creará
         * @return true si el directorio se pudo crear, false si no.
         */
        public bool makeDirectory(String dirname)
        {
            return false;
        }

        /**
         * Método para borrar un directorio
         * 
         * @param dirname nombre del directorio que se borrará
         * @return true si el directorio se pudo borrar, false si no.
         */
        public bool deleteDirectory(String dirname)
        {
            return false;
        }

        /**
         * Método encargado de mover un directorio de un lugar o otro
         * 
         * @param currentpath directorio que se va a mover
         * @param newpath ubicación a dónde se moverá el directorio
         * @return true si el directorio se pudo mover, false si no.
         */
        public bool moveDirectory(String currentpath, String newpath)
        {            
            return false;
        }

        /**
         * Método encargado de convertir el archivo a un arreglo de bytes
         * 
         * @param filename nombre del archivo que se desea convertir
         * @return el archivo en byte[]
         */
        public byte[] fileToBytes(String filename)
        {
            byte[] x = new byte[1];
            return x;
        }

        //Deprecated
        /**
         * Método encargado de convertir un arreglo a bytes hacia un archivo
         * 
         * @param bytesFile el arreglo de bytes del archivo
         * @param filename el nombre que se desea para el archivo
         * @return true si se pudo crear el archivo, false si no.
         */
        public bool bytesToFile(byte[] bytesFile, String filename)
        {            
            return false;
        }
    }
}
