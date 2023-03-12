using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AddonUpdater.Models
{
    public class GitHub
    {
        public string Name { get; set; } // название аддона
        public string Link { get; set; } // ссылка на toc
        public string Directory { get; set; } // /text/text.toc
        public string Version { get; set; } // Версия общая
        public string MyVersion { get; set; } // Моя версия
        public string Branches { get; set; } // Ветка на github
        public string Description { get; set; } // Описание
        public string Author { get; set; } // Автор
        public string GithubLink { get; set; } // Ссылка на github
        public string Forum { get; set; } // Ссылка на форум
        public string BugReport { get; set; } // Ссылка на BugReport
        public string Regex { get; set; } // Регулярное выражение
        public string Replace { get; set; } // Замена для регулярного выражения
        public string Category { get; set; } // Категория
        public bool NeedUpdate { get; set; } // Нужно обновление
        //public bool DownloadMyAddon { get; set; } // Скачать ?
        public bool SavedVariables { get; set; } // Общие настройки для аддона
        public bool SavedVariablesPerCharacter { get; set; } // Настройки аддона на персонажа
        public List<string> Files { get; set; } // Файлы

        public static bool operator ==(GitHub left, GitHub right)
        {
            return left.Name == right.Name && left.Link == right.Link && left.Directory == right.Directory &&
                left.Version == right.Version && left.MyVersion == right.MyVersion &&
                left.Branches == right.Branches && left.Description == right.Description &&
                left.Author == right.Author && left.GithubLink == right.GithubLink &&
                left.Forum == right.Forum && left.BugReport == right.BugReport &&
                left.Regex == right.Regex && left.Replace == right.Replace &&
                left.Category == right.Category && left.NeedUpdate == right.NeedUpdate &&
                left.SavedVariables == right.SavedVariables && left.SavedVariablesPerCharacter == right.SavedVariablesPerCharacter &&
                left.Files.SequenceEqual(right.Files);
        }

         public static bool operator !=(GitHub left, GitHub right) => !(left == right);

    }
}
