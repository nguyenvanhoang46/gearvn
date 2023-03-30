import React, { useMemo } from 'react'
import Navbar from '../Navbar'
import NavbarTop from '../NavbarTop'
import { Link } from "react-router-dom";
import { useState, useEffect } from 'react'
import { AiOutlineLoading, AiFillEdit } from 'react-icons/ai'
import { IoIosAddCircleOutline } from 'react-icons/io'
import { MdDelete } from 'react-icons/md';
import { deleteProductApi, getTableProductApi } from '../../app/services/adminService'
import Pagination from '../Pagination';
import './Product.css';
import { useQuery } from 'react-query';
import { useSearchParams } from "react-router-dom";
import { ToastContainer, toast } from 'react-toastify';
import 'react-toastify/dist/ReactToastify.css';
import { AuthContext } from '../../contexts/AuthProvider';
import { useContext } from 'react';

const TableProduct = () => {
    const { auth, clearAuth } = useContext(AuthContext);
    const [page, setPage] = useState(1)
    const [limit, setLimit] = useState(5)
    const { data, isLoading } = useQuery(['GET_PRODUCT_ADMIN_API', page, limit], () => getTableProductApi({ page, limit }))
    let [searchParams, setSearchParams] = useSearchParams();

    const handleDelete = async (id) => {
        try {
            console.log(id);
            const response = await deleteProductApi(id);
            console.log(response);
            data(
                data.filter((post) => {
                    window.location.reload(false)
                    return post.id != id;
                }));
        } catch (error) {
            console.log(error.message);
        }
    }

    useEffect(() => {
        const page = searchParams.get('page');
        setPage(page ?? 1)
    }, [])


    const changePage = (n) => {
        if (n < 1 || n > data.totalPages) return;

        setPage(n)
        setSearchParams({
            page: n
        })
    }


    console.log(data)

    return (
        <>
            {
                isLoading ? <div>Loading...</div> : (
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
                                        <Link to='/addproduct' className='block antialiased tracking-normal font-sans text-base font-semibold leading-relaxed flex items-center gap-2 text-white'><IoIosAddCircleOutline /> Add Product</Link>
                                    </div>
                                    <div className="p-6 overflow-x-scroll px-0 pt-0 pb-2">
                                        <table className='w-full min-w-[640px] table-auto'>
                                            <thead>
                                                <tr className=' '>
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
                                                        <p className="block antialiased font-sans text-[11px] font-bold uppercase text-blue-gray-400">Content</p>
                                                    </th>
                                                    <th className='border-b border-blue-gray-50 py-3 px-5 text-left'>
                                                        <p className="block antialiased font-sans text-[11px] font-bold uppercase text-blue-gray-400">Description</p>
                                                    </th>
                                                    <th className='border-b border-blue-gray-50 py-3 px-5 text-left'>
                                                        <p className="block antialiased font-sans text-[11px] font-bold uppercase text-blue-gray-400">Action</p>
                                                    </th>
                                                </tr>
                                            </thead>
                                            <tbody>
                                                {data?.data.map((item, index) => {
                                                    return (
                                                        <tr key={index} className='border-b-[1px]'>
                                                            <td className='py-3 px-5 w-[10%] '>
                                                                <img className='h-[100px] max-h-[100px]' src={item.images.length > 0 ? item.images[0].url : ""} alt="" />
                                                            </td>
                                                            <td className='py-3 px-5 w-[250px] '>{item.name}</td>
                                                            <td className='py-3 px-5 '>{item.price.toLocaleString('vi', { style: 'currency', currency: 'VND' })}</td>
                                                            <td className='py-3 px-5 '>{item.quantity}</td>
                                                            <td className='py-3 px-5 '>{item.salePrice.toLocaleString('vi', { style: 'currency', currency: 'VND' })}</td>
                                                            <td className='py-3 px-5 '>{item.category?.name}</td>
                                                            <td className='py-3 px-5 w-[300px]'>{item.content}</td>
                                                            <td className='py-3 px-5 w-[200px]'>{item.description}</td>
                                                            <td className='items-center h-[124px] gap-3 flex '>
                                                                <Link to={`/editproduct/${item.id}`}><AiFillEdit className='text-[20px] ' /></Link>
                                                                <button onClick={() => handleDelete(item.id)} > <MdDelete className='text-[20px]' /> </button>
                                                            </td>
                                                        </tr>
                                                    );
                                                })}
                                            </tbody>
                                        </table>
                                        <div className="my-[50px]">
                                            <div class="bg-white p-4 text-center items-center flex-wrap">
                                                <nav aria-label="Page navigation">
                                                    <ul class="inline-flex">
                                                        <li onClick={() => changePage(page - 1)}>
                                                            <button class="h-10 px-5 text-green-600 transition-colors duration-150 rounded-l-lg focus:shadow-outline hover:bg-green-100">
                                                                <svg class="w-4 h-4 fill-current" viewBox="0 0 20 20"><path d="M12.707 5.293a1 1 0 010 1.414L9.414 10l3.293 3.293a1 1 0 01-1.414 1.414l-4-4a1 1 0 010-1.414l4-4a1 1 0 011.414 0z" clip-rule="evenodd" fill-rule="evenodd"></path></svg>
                                                            </button>
                                                        </li>
                                                        {
                                                            Array(data?.totalPages ?? 1).fill(0).map((_, index) => {
                                                                if (index + 1 === Number(page)) {
                                                                    return (
                                                                        <li onClick={() => changePage(index + 1)}><button class="h-[30px] mt-1 px-[12px] rounded-[50%] text-white transition-colors duration-150 bg-green-600 border border-r-0 border-green-600 focus:shadow-outline">{index + 1}</button></li>
                                                                    )
                                                                }

                                                                return (
                                                                    <li onClick={() => changePage(index + 1)}><button class="h-[30px] px-[12px] ml-1 mt-1 rounded-[50%] text-green-600 transition-colors duration-150 focus:shadow-outline hover:bg-green-100">{index + 1}</button></li>
                                                                )
                                                            })
                                                        }
                                                        <li onClick={() => changePage(page + 1)}>
                                                            <button class="h-10 px-5 text-green-600 transition-colors duration-150 bg-white rounded-r-lg focus:shadow-outline hover:bg-green-100">
                                                                <svg class="w-4 h-4 fill-current" viewBox="0 0 20 20"><path d="M7.293 14.707a1 1 0 010-1.414L10.586 10 7.293 6.707a1 1 0 011.414-1.414l4 4a1 1 0 010 1.414l-4 4a1 1 0 01-1.414 0z" clip-rule="evenodd" fill-rule="evenodd"></path></svg>
                                                            </button>
                                                        </li>
                                                    </ul>
                                                </nav>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                )
            }
        </>
    )
}

export default TableProduct