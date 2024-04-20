function openmodal(url) {
    var xhr = new XMLHttpRequest();
    xhr.open('GET', url, true);
    xhr.onreadystatechange = function () {
        if (xhr.readyState === XMLHttpRequest.DONE) {
            if (xhr.status === 200) {
                document.querySelector("#exampleModalCenter .modal-content").innerHTML = xhr.responseText;
                var modal = new bootstrap.Modal(document.getElementById('exampleModalCenter'));
                modal.show();
            } else {
                console.error('Request failed:', xhr.status);
            }
        }
    };
    xhr.send();
}
