var ECommerce = {
    Page: {
        Home: {

        },
        Category: {
            Save: function () {
                var categoryId = $("#CategoryId").val();
                var productName = $("#ProductName").val();
                var jsonObj = new Object();
                jsonObj.CategoryId = categoryId;
                jsonObj.ProductName = productName;
                var json = JSON.stringify(jsonObj);


                $.ajax({
                    method: "POST",
                    url: "/api",
                    data: "JSON=" + json
                })
                    .done(function (msg) {
                        alert("Data Saved: " + msg);
                    });

            }
        },
        Contact: {

        },
        Help: {

        }
    }
}