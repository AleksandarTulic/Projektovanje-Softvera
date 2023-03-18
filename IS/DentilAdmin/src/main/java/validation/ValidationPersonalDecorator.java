package validation;

import dto.UserDTO;

public abstract class ValidationPersonalDecorator implements IValidation{
	protected IValidation iValidation;
	
	public ValidationPersonalDecorator(IValidation iValidation) {
		this.iValidation = iValidation;
	}
	
	@Override
	public boolean check(UserDTO dto) {
		return iValidation.check(dto);
	}
}
