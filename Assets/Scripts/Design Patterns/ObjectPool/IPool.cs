using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPool<T>
{
    public T Get();

    public void Release(T item);
}
