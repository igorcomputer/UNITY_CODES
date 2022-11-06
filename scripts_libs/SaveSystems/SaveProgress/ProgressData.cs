using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ����������� ������� - ��������� ������������� ������ ������ � ��������� ���� 
[System.Serializable]
public class ProgressData {
    public int Coins;
    public int Level;
    public float[] BackgroundColor;
    public bool IsMusicOn;

    // ����������� �������
    public ProgressData(Progress progress) {

        Coins = progress.Coins;
        Level = progress.Level;

        // �������������� ����� �� Unity
        // �.�. ����� �� ����������� �� MonoBehaviour
        BackgroundColor = new float[4];
        BackgroundColor[0] = progress.BackgroundColor.r;
        BackgroundColor[1] = progress.BackgroundColor.g;
        BackgroundColor[2] = progress.BackgroundColor.b;
        BackgroundColor[3] = 100f; // ����� ����� 
        IsMusicOn = progress.IsMusicOn;
    }
}
