import React from 'react'
import Navbar from '../Navbar'
import NavbarTop from '../NavbarTop'
import { Link, useNavigate, useParams } from "react-router-dom";
import { useState, useEffect } from 'react';
import { deleteUserApi, editUserApi, getTableUserApi } from '../../app/services/adminService';
import axios from 'axios';

const EditUser = () => {

    const [dataUser, setDataUser] = useState([]);

    const [username, setUserName] = useState("");
    const [firstName, setFirstName] = useState("");
    const [lastName, setLastName] = useState("");
    const [phoneNumber, setPhoneNumber] = useState("");
    const [email, setEmail] = useState("");
    const [password, setPassword] = useState("");
    const [role, setRole] = useState(1);
    const navigate = useNavigate();

    const { id } = useParams();

    // useEffect(() => {
    //     axios.get(`/Admin/User/User/`).then((res) => {
    //         setUserName(res.firstName);
    //         setFirstName(res.username);
    //         setLastName(res.lastName);
    //         setPhoneNumber(res.phoneNumber);
    //         setEmail(res.email);
    //         setPassword(res.password);
    //         setRole(res.role);
    //     })
    // })

    const handlEditUser = async (e) => {
        e.preventDefault();
        const response = await editUserApi({ username, firstName, lastName, phoneNumber, email, password, role });
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
                                <h6 className='block antialiased tracking-normal font-sans text-base font-semibold leading-relaxed text-white'>Add User</h6>
                            </div>
                            <div className="p-6 overflow-x-scroll px-0 pt-0 pb-2">
                                <form onSubmit={handlEditUser}>
                                    <div className="ml-10">
                                        <div className="gap-6 mt-5 items-center">
                                            <div className="flex gap-6 mt-4 items-center">
                                                <label className='font-medium text-[14px] w-[10%] '>FirstName</label>
                                                <div className='w-[60%]'>
                                                    <input value={username} onChange={(e) => setUserName(e.target.value)} className='w-full text-[#495057] bg-[#fff] py-[0.375rem] focus:bg-[#fff] px-[0.75rem]  focus:ring-offset-1 focus:ring-1 focus:outline   focus:outline-[#1b00ff] rounded-[.25rem] border-[1px] border-gray-200 ' type="text" placeholder="FirstName" />
                                                </div>
                                            </div>
                                        </div>
                                        <div className="flex gap-6 mt-7 items-center">
                                            <label className='font-medium text-[14px] w-[10%] '>FirstName</label>
                                            <div className='w-[60%]'>
                                                <input value={firstName} onChange={(e) => setFirstName(e.target.value)} className='w-full text-[#495057] bg-[#fff] py-[0.375rem] focus:bg-[#fff] px-[0.75rem]  focus:ring-offset-1 focus:ring-1 focus:outline   focus:outline-[#1b00ff] rounded-[.25rem] border-[1px] border-gray-200 ' type="text" placeholder="FirstName" />
                                            </div>
                                        </div>
                                        <div className="flex gap-6 mt-7 items-center">
                                            <label className='font-medium text-[14px] w-[10%] '>LastName</label>
                                            <div className='w-[60%]'>
                                                <input value={lastName} onChange={(e) => setLastName(e.target.value)} className='w-full text-[#495057] bg-[#fff] py-[0.375rem] focus:bg-[#fff] px-[0.75rem]  focus:ring-offset-1 focus:ring-1 focus:outline   focus:outline-[#1b00ff] rounded-[.25rem] border-[1px] border-gray-200 ' type="text" placeholder="LastName" />
                                            </div>
                                        </div>
                                        <div className="flex gap-6 mt-7 items-center">
                                            <label className='font-medium text-[14px] w-[10%] '>Phone</label>
                                            <div className='w-[60%]'>
                                                <input value={phoneNumber} onChange={(e) => setPhoneNumber(e.target.value)} className='w-full text-[#495057] bg-[#fff] py-[0.375rem] focus:bg-[#fff] px-[0.75rem]  focus:ring-offset-1 focus:ring-1 focus:outline   focus:outline-[#1b00ff] rounded-[.25rem] border-[1px] border-gray-200 ' type="text" placeholder="Phone" />
                                            </div>
                                        </div>
                                        <div className="flex gap-6 mt-7 items-center">
                                            <label className='font-medium text-[14px] w-[10%] '>Email</label>
                                            <div className='w-[60%]'>
                                                <input value={email} onChange={(e) => setEmail(e.target.value)} className='w-full text-[#495057] bg-[#fff] py-[0.375rem] focus:bg-[#fff] px-[0.75rem]  focus:ring-offset-1 focus:ring-1 focus:outline   focus:outline-[#1b00ff] rounded-[.25rem] border-[1px] border-gray-200 ' type="text" placeholder="Email" />
                                            </div>
                                        </div>
                                        <div className="flex gap-6 mt-7 items-center">
                                            <label className='font-medium text-[14px] w-[10%] '>Password</label>
                                            <div className='w-[60%]'>
                                                <input value={password} onChange={(e) => setPassword(e.target.value)} className='w-full text-[#495057] bg-[#fff] py-[0.375rem] focus:bg-[#fff] px-[0.75rem]  focus:ring-offset-1 focus:ring-1 focus:outline   focus:outline-[#1b00ff] rounded-[.25rem] border-[1px] border-gray-200 ' type="password" placeholder="Password" />
                                            </div>
                                        </div>
                                        <div className="pl-[180px] pb-6 pt-20 flex gap-4">
                                            <button type="submit" className="middle none font-sans font-bold center uppercase transition-all disabled:opacity-50 disabled:shadow-none disabled:pointer-events-none text-xs py-3 px-6 rounded-lg bg-gradient-to-tr from-blue-600 to-blue-400 text-white shadow-md shadow-blue-500/20 hover:shadow-lg hover:shadow-blue-500/40 active:opacity-[0.85] block ">Add User</button>
                                            <Link to='/tableuser' type="submit" className="middle none font-sans font-bold center uppercase transition-all disabled:opacity-50 disabled:shadow-none disabled:pointer-events-none text-xs py-3 px-6 rounded-lg bg-gradient-to-tr bg-[#EB5160] to-blue-400 text-white shadow-md shadow-blue-500/20 hover:shadow-lg hover:shadow-blue-500/40 active:opacity-[0.85] block ">Cancel</Link>
                                        </div>
                                    </div>
                                </form>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </>
    )
}

export default EditUser