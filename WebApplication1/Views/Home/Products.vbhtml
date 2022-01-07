@Code
    ViewData("Title") = "Products"
End Code

<h2>Products</h2>
<button class="btn-info alert-info">Tambah</button>
<table class="table table-hover">
    <thead>
        <tr>
            <th scope="col">#</th>
            <th scope="col">merchant id</th>
            <th scope="col">Name</th>
            <th scope="col">Price</th>
            <th scope="col">Status</th>
            <th scope="col">Created At</th>
            <th scope="col">Pilihan</th>
        </tr>
    </thead>
    <tbody>
       
        <tr>
            <th scope="row">1</th>
            <td>201</td>
            <td>acer aspire z3-451</td>
            <td>Rp. 2000.000</td>
            <td>available</td>
            <td>07-01-2022</td>
            
            <td>
                <a href="" class="badge badge-info"><i class="fas fa-edit"></i> Ubah
                </a>
                <a href="" onclick="return confirm('Kamu yakin akan menghapus ?');" class="badge badge-danger">
                    <i class="fa fa-trash"></i> Hapus
                </a>
            </td>
        </tr>
    </tbody>
</table>