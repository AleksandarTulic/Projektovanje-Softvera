package dto;

public class PairDTO<A, B> {
	private A a;
	private B b;
	
	public PairDTO() {
	}
	
	public void setA(A a) {
		this.a = a;
	}
	
	public void setB(B b) {
		this.b = b;
	}
	
	public A getA() {
		return a;
	}
	
	public B getB() {
		return b;
	}
}
