using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events; // !нужно импортировать пространство имен 

public class CollapseManager : MonoBehaviour {

    // Объявляем событие
    public UnityEvent onCollapse;


    // Триггерим событие (по какому нибудь условию, 
    // например, внутри метода 
    onCollapse.Invoke(); 
    
    
    // Подписываемся на событие - вешаем на него метод, 
    // который вывается, когда наступает событие)
    onCollapse.AddListener(DoSomething);
    
    // Вызываемый метод
    void DoSomething() {
        Debug.Log("Event Happend");
    }


}