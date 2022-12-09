using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunType : MonoBehaviour
{
    protected int guntype_id;
    protected string name;
    protected int reload;

    public GunType (int guntype_id, string name, int reload)
    {
        this.guntype_id = guntype_id;
        this.name = name;
        this.reload = reload;
    }
    
    public int getGuntypeID()
    {
        return this.guntype_id;
    }
    public string getName()
    {
        return this.name;
    }
    public int getReload()
    {
        return this.reload;
    }
}
