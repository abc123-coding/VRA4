using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//ScriptableObject클래스를 상속받는 추상클래스
public abstract class ItemEffect : ScriptableObject
{
    public abstract bool ExecuteRole();
}
