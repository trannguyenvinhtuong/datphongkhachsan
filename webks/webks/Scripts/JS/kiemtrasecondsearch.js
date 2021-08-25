const den = document.getElementById("date_den")
const di = document.getElementById("date_di");
const diadanh = document.getElementById("search_name");
const slphong = document.getElementById("slphong");
const slkhach = document.getElementById("slnglon");


function kiemtra() {
    const txtsearch = diadanh.value.trim();
    const txtden = den.value.trim();
    const txtdi = di.value.trim();
    const txtslphong = slphong.value.trim();
    const txtslkhach = slkhach.value.trim();
    if (txtsearch === '') {
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