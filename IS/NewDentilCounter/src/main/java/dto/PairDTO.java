package dto;

import java.util.Objects;

public class PairDTO<A, B> {
	private A a;
	private B b;
	
	public PairDTO() {
	}
	
	public PairDTO(A a, B b) {
		this.a = a;
		this.b = b;
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

	@Override
	public int hashCode() {
		return Objects.hash(a, b);
	}

	@Override
	public boolean equals(Object obj) {
		if (this == obj)
			return true;
		if (obj == null)
			return false;
		if (getClass() != obj.getClass())
			return false;
		PairDTO<?, ?> other = (PairDTO<?, ?>) obj;
		return Objects.equals(a, other.a) && Objects.equals(b, other.b);
	}

	@Override
	public String toString() {
		return "PairDTO [a=" + a + ", b=" + b + "]";
	}
	
}
