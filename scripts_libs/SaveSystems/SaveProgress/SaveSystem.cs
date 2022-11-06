using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

// Статический класс для сохранения сериализованных данных в файл (все методы статические) - static 
// Данные после сериализации не подлежат дешифровке (защита от читеров) 
public static class SaveSystem {

    // Платформонезависимый путь сохранения + "/название файла с любым расширением"
    private static string path = Application.persistentDataPath + "/ progress.data";

    // Сохранение данных (на входе объект с данными игры) 
    public static void Save(Progress progress) {

        // Класс для преобразования данных из ProgressData в битовый формат
        BinaryFormatter binaryFormatter = new BinaryFormatter();

        // Создаем файл
        FileStream fileStream = new FileStream(path, FileMode.Create);

        // Подготавливаем данные для сохранения
        ProgressData progressData = new ProgressData(progress);

        // Сохраняем сериализованные данные 
        binaryFormatter.Serialize(fileStream, progressData);

        // Закрываем файл (обязательно!) 
        fileStream.Close();

    }

    // Загрузка сохраненных данныех и файла 
    public static ProgressData Load() {

        if (File.Exists(path)) {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            FileStream fileStream = new FileStream(path, FileMode.Open);
            ProgressData progressData = binaryFormatter.Deserialize(fileStream) as ProgressData;
            fileStream.Close();
            return progressData;
        } else {
            Debug.Log("Has No File to Save!");
            return null;
        }

    }

    public static void DeleteDataFile() {
        File.Delete(path);
    }

}
