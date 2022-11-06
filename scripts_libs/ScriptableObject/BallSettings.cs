using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class BallSettings : ScriptableObject {
    public Material[] BallMaterials;
    public Material[] BallProjectionMaterials; 
}


/*
 
Скрипт, позволяющий создать специальный объект для хранения настроек игры 
У объекта настроек игры появятся соответсвующие поля (как у класса) 

- Создается файл с полями для настроек (публичные)
- Наследуется от класса ScriptableObject 
- Добавляется атрибут [CreateAssetMenu] 

- затем создаем объекта в контекстном меню: 
http://joxi.ru/D2PvDlEcWB6YPr 

- На выходе получим объект ScriptableObject (BallSettings в нашем случае), 
  к которому можем обращаться во время игры 

- ScriptableObject - является сквозным для игры (к нему можно обращаться из разных сцен) 

 * */