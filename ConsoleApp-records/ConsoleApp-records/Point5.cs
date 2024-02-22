


#region immutable struct record



public readonly record struct Point5{
	public readonly int x;
	public readonly int  y;
	public Point5() {  x = 0; y = 0;}
	public Point5(int x) {  this.x = x; y = 0;}
};

#endregion