document.querySelector('.img__btn').addEventListener('click', function () {
    document.querySelector('.cont').classList.toggle('s--signup');
});

$('.js-hide-modal1').on('click', function () {
    $('.js-modal1').removeClass('show-modal1');
});

$("#registerForm").submit(function (e) {
    e.preventDefault();
    var formData = $(this).serialize();

    $.ajax({
        type: 'post',
        data: formData,
        url: 'Account/Register',
        success: function (res) {
            swal('Tạo thành công', "Bạn phải xác nhận email mới khi được đăng nhập nhé", "success")
        },
        error: function (res) {
            if (res.status == 69) {
                swal('Hãy thử lại', "Tên email nãy đã được sử dụng", "info")
            }
        }
    });

});

$("#loginForm").submit(function (e) {
    e.preventDefault();
    var formData = $(this).serialize();

    $.ajax({
        type: 'POST',
        data: formData,
        url: 'Account/Login',
        success: function (res) {
            location.reload();
        },
        error: function (res) {
            if (res.status == 69) {
                swal('Hãy thử lại', "Tên tài khoản hoặc mật khẩu không đúng", "error")
            }
        }
    });

});