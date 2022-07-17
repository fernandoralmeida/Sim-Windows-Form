using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;

namespace Sim.Classes
{
    public class Arquivos
    {
        
        //retorna os arquivos de um diretório

        public List<string> Listar(string diretorio)
        {            
            var nfiles = Directory.GetFiles(diretorio, "*.*", SearchOption.AllDirectories);
            return nfiles.ToList();
        }

        public List<FileInfo> FileName(string caminho)
        {
            var result = from file in new System.IO.DirectoryInfo(caminho).EnumerateFiles() select file;
            return result.ToList();
        }

        public string[] GetFiles(string pathfile)
        {
            return Directory.GetFiles(pathfile, "*.*", SearchOption.AllDirectories);
        }

        //delete os arquivos de um diretório
        public void DelFiles(string pathfile)
        {
            // verifica se o caminho exite
            if (Directory.Exists(pathfile))
            {
                string[] nfiles = Directory.GetFiles(pathfile);
                
                //deleta um arquivo de cada vez
                foreach (string files in nfiles)
                {
                    string arquivo = Path.GetFullPath(files);
                    File.Delete(arquivo);
                }
                
            }     
        }       

    }
}
