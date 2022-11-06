using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

// ����������� ����� ��� ���������� ��������������� ������ � ���� (��� ������ �����������) - static 
// ������ ����� ������������ �� �������� ���������� (������ �� �������) 
public static class SaveSystem {

    // �������������������� ���� ���������� + "/�������� ����� � ����� �����������"
    private static string path = Application.persistentDataPath + "/ progress.data";

    // ���������� ������ (�� ����� ������ � ������� ����) 
    public static void Save(Progress progress) {

        // ����� ��� �������������� ������ �� ProgressData � ������� ������
        BinaryFormatter binaryFormatter = new BinaryFormatter();

        // ������� ����
        FileStream fileStream = new FileStream(path, FileMode.Create);

        // �������������� ������ ��� ����������
        ProgressData progressData = new ProgressData(progress);

        // ��������� ��������������� ������ 
        binaryFormatter.Serialize(fileStream, progressData);

        // ��������� ���� (�����������!) 
        fileStream.Close();

    }

    // �������� ����������� ������� � ����� 
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
