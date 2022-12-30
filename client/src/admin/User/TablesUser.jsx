import React from 'react'
import Navbar from '../Navbar'
import NavbarTop from '../NavbarTop'
import { Link } from "react-router-dom";
import { useState, useEffect } from 'react';
import { getTableUserApi } from '../../app/services/adminService';



const TablesUser = () => {

    const [dataUser, setDataUser] = useState([]);

    useEffect(() => {
        const getAllUser = async () => {
            try {
                const data = await getTableUserApi();
                setDataUser(data.data);
                console.log(data);
            } catch (error) {
                console.log(error.message);
            }
        }
        getAllUser();
    }, []);

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
                                <h6 className='block antialiased tracking-normal font-sans text-base font-semibold leading-relaxed text-white'>User</h6>
                                <Link to='/adduser' className='block antialiased tracking-normal font-sans text-base font-semibold leading-relaxed text-white'>Add User</Link>
                            </div>
                            <div className="p-6 overflow-x-scroll px-0 pt-0 pb-2">
                                <table className='w-full min-w-[640px] table-auto'>
                                    <thead>
                                        <tr>
                                            <th className='border-b border-blue-gray-50 py-3 px-5 text-left'>
                                                <p className="block antialiased font-sans text-[11px] font-bold uppercase text-blue-gray-400">UserName</p>
                                            </th>
                                            <th className='border-b border-blue-gray-50 py-3 px-5 text-left'>
                                                <p className="block antialiased font-sans text-[11px] font-bold uppercase text-blue-gray-400">Phone</p>
                                            </th>
                                            <th className='border-b border-blue-gray-50 py-3 px-5 text-left'>
                                                <p className="block antialiased font-sans text-[11px] font-bold uppercase text-blue-gray-400">Email</p>
                                            </th>
                                            <th className='border-b border-blue-gray-50 py-3 px-5 text-left'>
                                                <p className="block antialiased font-sans text-[11px] font-bold uppercase text-blue-gray-400">Role</p>
                                            </th>
                                            <th className='border-b border-blue-gray-50 py-3 px-5 text-left'>
                                                <p className="block antialiased font-sans text-[11px] font-bold uppercase text-blue-gray-400">Action</p>
                                            </th>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        {dataUser.map((item, index) => {
                                            return (
                                                <tr>
                                                    <td className='py-3 px-5'>{item.fullName}</td>
                                                    <td className='py-3 px-5 '>{item.phone}</td>
                                                    <td className='py-3 px-5 '>{item.email}</td>
                                                    <td className='py-3 px-5 '>Role</td>
                                                    <td className='py-3 px-5 flex gap-3'>
                                                        <button>Sửa</button>
                                                        <button>Xóa</button>
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

export default TablesUser