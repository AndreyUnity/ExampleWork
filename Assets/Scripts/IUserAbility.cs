using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IUserAbility
{
    bool Locked { get; }
    void Lock();
    void Unlock();
}
