import React from 'react'
import Navbar from '../Navbar'
import NavbarTop from '../NavbarTop'
import { Link } from "react-router-dom";
import { useState, useEffect } from 'react'
import { deleteProductApi, getTableCategoryApi, getTableProductApi } from '../../app/services/adminService'

const TableProduct = () => {
    const [dataProduct, setDataProduct] = useState([]);

    // console.log("da",dataProduct);
    useEffect(() => {
        const getAllProduct = async () => {
            const data = await getTableProductApi();
            setDataProduct(data.data);
            console.log("hoang", data);
        }
        getAllProduct();
    }, []);

    const handleDelete = async (id) => {
        try {
            console.log(id);
            const response = await deleteProductApi(id);
            console.log(response);
            setDataProduct(
                dataProduct.filter((post) => {
                    return post.id != id;
                }));
        } catch (error) {
            console.log(error.message);
        }
    }

    return (
        <>
            <div className="bg-[#eceff1] min-h-[1070px]">
                <div className="grid grid-cols-12  ">
                    <div className="col-span-2">
                        <Navbar />
                    </div>
                    <div className="col-span-10">
                        <div className="mt-5"><NavbarTop /></div>
                        <div className="relative flex flex-col bg-clip-border rounded-xl bg-white text-gray-700 shadow-md mt-12 mb-8  gap-12">
                            <div className="relative flex justify-between bg-clip-border mx-4 rounded-xl overflow-hidden bg-gradient-to-tr from-blue-600 to-blue-400 text-white shadow-blue-500/40 shadow-lg -mt-6  p-6">
                                <h6 className='block antialiased tracking-normal font-sans text-base font-semibold leading-relaxed text-white'>Product</h6>
                                <Link to='/addproduct' className='block antialiased tracking-normal font-sans text-base font-semibold leading-relaxed text-white'>Add Product</Link>
                            </div>
                            <div className="p-6 overflow-x-scroll px-0 pt-0 pb-2">
                                <table className='w-full min-w-[640px] table-auto'>
                                    <thead>
                                        <tr>
                                            <th className='border-b border-blue-gray-50 py-3 px-5 text-left'>
                                                <p className="block antialiased font-sans text-[11px] font-bold uppercase text-blue-gray-400">Image</p>
                                            </th>
                                            <th className='border-b border-blue-gray-50 py-3 px-5 text-left'>
                                                <p className="block antialiased font-sans text-[11px] font-bold uppercase text-blue-gray-400">Name</p>
                                            </th>
                                            <th className='border-b border-blue-gray-50 py-3 px-5 text-left'>
                                                <p className="block antialiased font-sans text-[11px] font-bold uppercase text-blue-gray-400">Price</p>
                                            </th>
                                            <th className='border-b border-blue-gray-50 py-3 px-5 text-left'>
                                                <p className="block antialiased font-sans text-[11px] font-bold uppercase text-blue-gray-400">Quantity</p>
                                            </th>
                                            <th className='border-b border-blue-gray-50 py-3 px-5 text-left'>
                                                <p className="block antialiased font-sans text-[11px] font-bold uppercase text-blue-gray-400">Sale</p>
                                            </th>
                                            <th className='border-b border-blue-gray-50 py-3 px-5 text-left'>
                                                <p className="block antialiased font-sans text-[11px] font-bold uppercase text-blue-gray-400">Category</p>
                                            </th>
                                            <th className='border-b border-blue-gray-50 py-3 px-5 text-left'>
                                                <p className="block antialiased font-sans text-[11px] font-bold uppercase text-blue-gray-400">Description</p>
                                            </th>
                                            <th className='border-b border-blue-gray-50 py-3 px-5 text-left'>
                                                <p className="block antialiased font-sans text-[11px] font-bold uppercase text-blue-gray-400">Content</p>
                                            </th>
                                            <th className='border-b border-blue-gray-50 py-3 px-5 text-left'>
                                                <p className="block antialiased font-sans text-[11px] font-bold uppercase text-blue-gray-400">Action</p>
                                            </th>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        {dataProduct.map((item, index) => {
                                            // console.log(item.images);
                                            return (
                                                <tr key={index} className=''>
                                                    <td className='py-3 px-5 w-[10%] '>
                                                        <img className='h-[100px] max-h-[100px]' src={item.images.length > 0 ? item.images[0].url : ""} alt="" />
                                                    </td>
                                                    <td className='py-3 px-5 w-[250px] '>{item.name}</td>
                                                    <td className='py-3 px-5 '>{item.price}</td>
                                                    <td className='py-3 px-5 '>{item.quantity}</td>
                                                    <td className='py-3 px-5 '>{item.salePrice}</td>
                                                    <td className='py-3 px-5 '>g</td>
                                                    <td className='py-3 px-5 w-[300px]'>{item.content}</td>
                                                    <td className='py-3 px-5 w-[200px]'>{item.description}</td>
                                                    <td className='py-3 px-5 gap-3 flex '>
                                                    <Link to={`/editproduct/${item.id}`}  >Sửa</Link>
                                                        <button onClick={() => handleDelete(item.id)} >Xóa</button>
                                                    </td>
                                                </tr>
                                            );
                                        })}
                                    </tbody>
                                </table>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </>
    )
}

export default TableProduct