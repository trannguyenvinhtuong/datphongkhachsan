const dk_form = document.getElementById('IDform-dk');
const dk_username = document.getElementById('dk-tendn');
const dk_email = document.getElementById('dk-email');
const dk_mk = document.getElementById('dk-mk');
const dk_xnmk = document.getElementById('dk-xnmk');
const dk_sdt = document.getElementById('dk-sdt');

//dk_form.addEventListener('submit', (e) => {
//	e.preventDefault();
//	checkinput();
//});
function checkinput() {
	const username = dk_username.value.trim();
	const email = dk_email.value.trim();
	const mk = dk_mk.value.trim();
	const xnmk = dk_xnmk.value.trim();
	const sdt = dk_sdt.value.trim();

	if (username === '') {
		setErrorFor(dk_username, 'Tên đăng nhập không được để trống');
	}

	else if (email === '') {
		setErrorFor(dk_email, 'Email không được để trống');
		setSuccessFor(dk_username);
	}
	else if (!isEmail(email)) {
		setErrorFor(dk_email, 'Email không hợp lệ');
		setSuccessFor(dk_username);
	}

	else if (mk === '') {
		setErrorFor(dk_mk, 'Mật khẩu không được để trống');
		setSuccessFor(dk_username);
		setSuccessFor(dk_email);
	}

	else if (xnmk === '') {
		setErrorFor(dk_xnmk, 'Xác nhận mật khẩu không được để trống');
		setSuccessFor(dk_username);
		setSuccessFor(dk_email);
		setSuccessFor(dk_mk);
	}
	else if (mk != xnmk) {
		setErrorFor(dk_xnmk, 'Xác nhận không hợp lệ');
		setSuccessFor(dk_username);
		setSuccessFor(dk_email);
		setSuccessFor(dk_mk);
	}
	else if (sdt === '') {
		setErrorFor(dk_sdt, 'Số điện thoại không được để trống');
		setSuccessFor(dk_username);
		setSuccessFor(dk_email);
		setSuccessFor(dk_mk);
		setSuccessFor(dk_xnmk);
	}
	else if (isSDT(sdt) == false) {
		setErrorFor(dk_sdt, 'Số điện thoại không hợp lệ');
		setSuccessFor(dk_username);
		setSuccessFor(dk_email);
		setSuccessFor(dk_mk);
		setSuccessFor(dk_xnmk);
	}
	else {
		setSuccessFor(dk_username);
		setSuccessFor(dk_email);
		setSuccessFor(dk_mk);
		setSuccessFor(dk_xnmk);
		setSuccessFor(dk_sdt);
		return true;
	}
	return false;
}
function setErrorFor(input, message) {
	const formcontrol = input.parentElement;
	const small = formcontrol.querySelector('small');
	small.innerText = message;
	formcontrol.className = 'form-dk-control fail';
}
function setSuccessFor(input) {
	const formcontrol = input.parentElement;
	formcontrol.className = 'form-dk-control sucess';
}
function isEmail(email) {
	return /^(([^<>()[\]\\.,;:\s@"]+(\.[^<>()[\]\\.,;:\s@"]+)*)|(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/.test(email);
}
function isSDT(sdt) {
	var vn_regex = /((09|03|07|08|05)+([0-9]{8})\b)/g;
	return vn_regex.test(sdt);
}