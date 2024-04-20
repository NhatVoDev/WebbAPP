//function openmodal() {
//    var xhr = new XMLHttpRequest();
//    xhr.open('GET',url, true);
//    xhr.onreadystatechange = function () {
//        if (xhr.readyState === XMLHttpRequest.DONE) {
//            if (xhr.status === 200) {
//                // Nếu yêu cầu thành công, hiển thị PartialView trong modal
//                document.querySelector("#exampleModalCenter .modal-content").innerHTML = xhr.responseText;
//                // Hiển thị modal
//                var modal = new bootstrap.Modal(document.getElementById('exampleModalCenter'));
//                modal.show();
//            } else {
//                // Xử lý trường hợp yêu cầu không thành công
//                console.error('Request failed:', xhr.status);
//            }
//        }
//    };
//    xhr.send();
//}
//function test(){
//    alert("ok")
//}