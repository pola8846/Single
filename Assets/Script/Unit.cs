using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum STATE
{
	STUN,
	BIND,
	UNARMED,
	SILENCE,
	BLEED,
	POISON,
	CHANGEMHPFIX,
	CHANGEMHPRATE,
	CHANGEATKFIX,
	CHANGEATKRATE,
	CHANGEDEFFIX,
	CHANGEDEFRATE,
	CHANGEASPFIX,
	CHANGEASPRATE,
	CHANGEMSPFIX,
	CHANGEMSPRATE,
	BAD,
}
public enum PARAMETER
{
	HP,
	MHP,
	ATK,
	DEF,
	ASP,
	MSP,
}
public class Damage
{
	//대미지 클래스

}
public class State
{
	//상태이상 클래스
	private Dictionary<STATE, int> state;
	private delegate void Timer(Unit target);

	public State(Dictionary<STATE, int> state)
	{
		this.state = state;
	}
	public bool SearchState(STATE st)//해당옵션이 있는가?
	{
		return state.ContainsKey(st);
	}
}
public class Unit:MonoBehaviour
{
	//유닛 클래스. 단독으로 사용하지 않고 플레이어, 적 유닛 클래스에서 상속해서 쓸 것임
	private Dictionary<PARAMETER, int> stats;//스텟
	private List<State> states;//상태이상
	public void InitStat(Dictionary<PARAMETER, int> entry)
	{

    }
	public int GetStat(PARAMETER type)//실적용값을 반환한다.
    {
		return 0;
    }
	public void Dead()//죽는다.
    {

    }
	public void Damaged(Damage dam)//피해를 입는다.
    {
		int result = 0;
    }
	public bool ChangeHp(int damage)//실제 HP를 변경한다. 죽는 건 여기서(죽으면 true반환)
    {
		stats[PARAMETER.HP] += damage;
		Mathf.Clamp(stats[PARAMETER.HP], 0, stats[PARAMETER.MHP]);
		if (stats[PARAMETER.HP] <= 0)
        {
			Dead();
			return true;
        }
		return false;
    }
}
