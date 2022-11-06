using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class BallSettings : ScriptableObject {
    public Material[] BallMaterials;
    public Material[] BallProjectionMaterials; 
}


/*
 
������, ����������� ������� ����������� ������ ��� �������� �������� ���� 
� ������� �������� ���� �������� �������������� ���� (��� � ������) 

- ��������� ���� � ������ ��� �������� (���������)
- ����������� �� ������ ScriptableObject 
- ����������� ������� [CreateAssetMenu] 

- ����� ������� ������� � ����������� ����: 
http://joxi.ru/D2PvDlEcWB6YPr 

- �� ������ ������� ������ ScriptableObject (BallSettings � ����� ������), 
  � �������� ����� ���������� �� ����� ���� 

- ScriptableObject - �������� �������� ��� ���� (� ���� ����� ���������� �� ������ ����) 

 * */