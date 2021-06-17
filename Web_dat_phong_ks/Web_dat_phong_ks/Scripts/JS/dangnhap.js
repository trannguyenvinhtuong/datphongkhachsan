const dn_tendn = document.getElementById("dn-tendn");
const dn_mk = document.getElementById("dn-mk");
function checkdninput(){
	const username = dn_tendn.value.trim();
	const mk = dn_mk.value.trim();
	if (username === '') {
		setErrorFor(dn_tendn, 'Tên đăng nhập không được để trống');
	}
	else if (password === '') {
		setErrorFor(dn_mk, 'Mật khẩu không được để trống');
		setSuccessFor(dn_tendn);
	}
	else {
		setSuccessFor(dn_tendn);
		setSuccessFor(dn_mk);
		return true;
	}
	return false;
}
function setErrorFor(input, message) {
	const formcontrol = input.parentElement;
	const small = formcontrol.querySelector('small');
	small.innerText = message;
	formcontrol.className = 'form-dn-control fail';
}
function setSuccessFor(input) {
	const formcontrol = input.parentElement;
	formcontrol.className = 'form-dn-control sucess';
}