
using System;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    public enum ETipo
    {
        XML,
        JSON
    }
    public class Serializer<T> : IArchivo<T> where T : new()
    {
        ETipo tipo;
        public Serializer(ETipo tipo)
        {
            this.tipo = tipo;
        }
        /// <summary>
        /// Serializa y escribe un dato en un archivo json o xml.
        /// </summary>
        /// <param name="dato"></param>
        /// <param name="path"></param>
        public void Escribir(T dato, string path)
        {
            if (this.tipo == ETipo.XML)
            {
                if (Path.GetExtension(path) == ".xml")
                {
                    using (XmlTextWriter tw = new XmlTextWriter(path, Encoding.UTF8))
                    {
                        tw.Formatting = Formatting.Indented;
                        XmlSerializer xmlSer = new XmlSerializer(typeof(T));
                        xmlSer.Serialize(tw, dato);
                    }
                }
                else
                {
                    throw new InvalidExtensionException("Extension invalida para tipo de archivo XML.");
                }
            }
            else
            {
                if (Path.GetExtension(path) == ".json")
                {
                    ArchivoText archivoJson = new ArchivoText();
                    JsonSerializerOptions opciones = new JsonSerializerOptions();
                    opciones.WriteIndented = true;
                    archivoJson.Escribir(JsonSerializer.Serialize(dato, typeof(T), opciones), path);

                }
                else
                {
                    throw new InvalidExtensionException("Extension invalida para tipo de archivo JSON.");
                }
            }

        }
        /// <summary>
        /// Lee un dato de un archivo json o xml.
        /// </summary>
        /// <param name="path"></param>
        /// <returns>Devuelve el dato deserializado.</returns>
        public T Leer(string path)
        {
            T objeto = new T();
            if (this.tipo == ETipo.XML)
            {
                if (Path.GetExtension(path) == ".xml")
                {
                    try
                    {
                        using (XmlTextReader xmlTr = new XmlTextReader(path))
                        {
                            XmlSerializer xmlSer = new XmlSerializer(typeof(T));
                            return (T)xmlSer.Deserialize(xmlTr);
                        }
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
                else { throw new InvalidExtensionException("Extension invalida para tipo de archivo XML."); }
            }
            else
            {
                if (Path.GetExtension(path) == ".json")
                {

                    try
                    {
                        string json = File.ReadAllText(path);
                        objeto = JsonSerializer.Deserialize<T>(json);
                        return objeto;
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
                else { throw new InvalidExtensionException("Extension invalida para tipo de archivo XML."); }

            }
        }
    }
}
