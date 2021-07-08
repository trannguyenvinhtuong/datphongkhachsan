const den = document.getElementById("ngayden");
const di = document.getElementById("ngaydi");
const diadanh = document.getElementById("keyword");
const slphong = document.getElementById("soluongphong");
const slkhach = document.getElementById("soluongkhach");

var now = new Date();
document.getElementById("ngayden").valueAsDate = now;
var nextday = new Date();
nextday.setDate(nextday.getDate() + 1);
document.getElementById("ngaydi").valueAsDate = nextday;
document.getElementById("soluongphong").value = 1;
document.getElementById("soluongkhach").value = 2;

function kiemtradulieu() {
    const txtden = den.value.trim();
    const txtdi = di.value.trim();
    const txtslphong = slphong.value.trim();
    const txtslkhach = slkhach.value.trim();
    const txtdiadanh = diadanh.value.trim();

    if (txtdiadanh === '') {
        alert("Không được để trống tên địa danh");
        
    }
    else if (txtden === txtdi) {
        alert("Ngày đến không được trùng ngày đi");
        
    }
    else if (txtden > txtdi) {
        alert("Ngày đến phải lớn hơn ngày đi");        
    }
    else if (txtslphong === "") {
        alert("Số lượng phòng không hợp lệ");
        return false;
    }
    else if (txtslphong < 0) {
        alert("Số lượng phòng không hợp lệ");
        return false;
    }
    else if (txtslkhach === "") {
        alert("Số lượng khách không hợp lệ");
        return false;
    }
    else if (txtslkhach < 0) {
        alert("Số lượng khách không hợp lệ");
        return false;
    }   
    
    else {
        return true;        
    }
    return false;
}
