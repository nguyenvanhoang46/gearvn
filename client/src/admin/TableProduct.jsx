import React from 'react'
import Navbar from './Navbar'
import NavbarTop from './NavbarTop'

const TableProduct = () => {
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
                            <div className="relative bg-clip-border mx-4 rounded-xl overflow-hidden bg-gradient-to-tr from-blue-600 to-blue-400 text-white shadow-blue-500/40 shadow-lg -mt-6  p-6">
                                <h6 className='block antialiased tracking-normal font-sans text-base font-semibold leading-relaxed text-white'>Product</h6>
                            </div>
                            <div className="p-6 overflow-x-scroll px-0 pt-0 pb-2">
                                <table className='w-full min-w-[640px] table-auto'>
                                    <thead>
                                        <tr>
                                            <th className='border-b border-blue-gray-50 py-3 px-5 text-left'>
                                                <p class="block antialiased font-sans text-[11px] font-bold uppercase text-blue-gray-400">Image</p>
                                            </th>
                                            <th className='border-b border-blue-gray-50 py-3 px-5 text-left'>
                                                <p class="block antialiased font-sans text-[11px] font-bold uppercase text-blue-gray-400">Name</p>
                                            </th>
                                            <th className='border-b border-blue-gray-50 py-3 px-5 text-left'>
                                                <p class="block antialiased font-sans text-[11px] font-bold uppercase text-blue-gray-400">Price</p>
                                            </th>
                                            <th className='border-b border-blue-gray-50 py-3 px-5 text-left'>
                                                <p class="block antialiased font-sans text-[11px] font-bold uppercase text-blue-gray-400">Quantity</p>
                                            </th>
                                            <th className='border-b border-blue-gray-50 py-3 px-5 text-left'>
                                                <p class="block antialiased font-sans text-[11px] font-bold uppercase text-blue-gray-400">Description</p>
                                            </th>
                                            <th className='border-b border-blue-gray-50 py-3 px-5 text-left'>
                                                <p class="block antialiased font-sans text-[11px] font-bold uppercase text-blue-gray-400">Category</p>
                                            </th>
                                            <th className='border-b border-blue-gray-50 py-3 px-5 text-left'>
                                                <p class="block antialiased font-sans text-[11px] font-bold uppercase text-blue-gray-400">Content</p>
                                            </th>
                                            <th className='border-b border-blue-gray-50 py-3 px-5 text-left'>
                                                <p class="block antialiased font-sans text-[11px] font-bold uppercase text-blue-gray-400">Action</p>
                                            </th>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        <tr className=''>
                                            <td className='py-3 px-5 w-[10%] '>
                                                <img className='h-[100px] max-h-[100px]' src="//product.hstatic.net/1000026716/product/54mv_92471e86b1c8419d98674dd9e90c7d78_large.png" alt="" />
                                            </td>
                                            <td className='py-3 px-5 '>g</td>
                                            <td className='py-3 px-5 '>g</td>
                                            <td className='py-3 px-5 '>g</td>
                                            <td className='py-3 px-5 '>g</td>
                                            <td className='py-3 px-5 '>g</td>
                                            <td className='py-3 px-5 '>g</td>
                                            <td className='py-3 px-5 '>g</td>

                                        </tr>
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