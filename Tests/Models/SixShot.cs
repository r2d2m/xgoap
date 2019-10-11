using System;

/* A one trick poney that can actually trot */
namespace Activ.GOAP{
[Serializable] public class SixShot : Agent{

    public float cost { get; set; }
    int shots = 6;

    public ante Shoot(){
        cost  += 1;
        shots -= 1;
        return true;
    }

    Func<ante>[] Agent.actions
    => shots<=0 ? null : new Func<ante>[]{ Shoot };

    override public int GetHashCode() => shots;

    override public bool Equals(object other){
        if(other == null) return false;
        if(other is SixShot that) return this.shots == that.shots;
        return false;
    }

}}
