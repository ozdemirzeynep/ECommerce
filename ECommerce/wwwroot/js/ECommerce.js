var ECommerce = {
    Helper: {
        Ajax: function (method, jDto, callback) {
            var json = JSON.stringify(jDto);

            var data = new Object();
            data.Method = method;
            data.Json = json;

            $.ajax({
                method: "POST",
                url: "/api",
                data: "JSON=" + JSON.stringify(data)
            })
                .done(function (msg) {
                    if (callback) {
                        callback(msg);
                    }
                });



        }
    },
    Page: {
        Home: {

        },
        Category: {
            Save: function () {
                var categoryId = $("#CategoryId").val();
                var productName = $("#ProductName").val();
                var productDescription = $("#ProductDescription").val();
                var jDto = new Object();  
                jDto.CategoryId = categoryId; 
                jDto.ProductName = productName;
                jDto.ProductDescription = productDescription;

                ECommerce.Helper.Ajax("SaveProduct", jDto, ECommerce.Page.Category.Callback_Save);


            },
            Remove: function (productId) {
                var jDto = new Object();
                jDto.ProductId = productId;
                ECommerce.Helper.Ajax("RemoveProduct", jDto, ECommerce.Page.Category.Callback_Remove);
            },
            List: function () {
               
                    var categoryId = $("#CategoryId").val();
                    var jDto = new Object();
                    jDto.CategoryId = categoryId;
                    ECommerce.Helper.Ajax("ProductsByCategoryId", jDto, ECommerce.Page.Category.Callback_List);

                

            },
            Update: function () {
                debugger;
                var productId = $("#Id").val();
                var productName = $("#Name").val();
                var productDescription = $("#Description").val();
                var jDto = new Object();
                jDto.ProductId = productId;
                jDto.ProductName = productName;
                jDto.ProductDescription = productDescription;

               
                ECommerce.Helper.Ajax("UpdateProduct", jDto, ECommerce.Page.Category.Callback_Save);
                

            },
            Callback_List: function (data) {
                console.log(data);
                var html = "";

                for (var i = 0; i < data.dynamic.length; i++) {
                    var product = data.dynamic[i];
                    var productName = product.name;

                    //html += "- <a href='/urun/" + product.id + "'>" + productName + "</a>"
                    html += "- <a href='/urun/" + product.id + "'>" + productName + "</a> <input type='button' value='Sil' onclick='ECommerce.Page.Category.Remove(" + product.id + ")' /><br />";
                }

                $("#Holder-Products").html(html);


            },
            Callback_Remove: function () {
                ECommerce.Page.Category.List();

            },

        
            Callback_Save: function (data) {
                ECommerce.Page.Category.List();
                alert("Ürün başarılı şekilde kaydedildi.");
            },
        
 
        },
        Contact: {
            Send: function () {
                var name = $("#Name").val();
                var surname = $("#Surname").val();
                var message = $("#Message").val();
                var jDto = new Object();
                jDto.Name = name;
                jDto.Surname = surname;
                jDto.Message = message;

                ECommerce.Helper.Ajax("SaveContact", jDto, ECommerce.Page.Contact.Callback_Save);
            },
            Callback_Save: function (data) {
                alert("mesajınız başarıyla iletilmiştir.")
            }

        },
        Help: {

        },
        
    }
}