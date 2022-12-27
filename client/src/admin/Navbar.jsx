import React from 'react'
import { Link } from 'react-router-dom'
import { FaHome } from 'react-icons/fa';
import { SiInstructables } from 'react-icons/si';

const Navbar = () => {
    return (
        <>
            <div className="">
                <div className="w-72 bg-[#263238] rounded-xl ml-4 my-4 fixed inset-0 z-50">
                    <div className="relative border-b border-white/20 ">
                        <Link className='px-8 py-6 gap-4 items-center flex uppercase ' to="/">
                            <h6 className='text-white font-semibold leading-relaxed '>Nguyễn Văn Hoàng</h6>
                        </Link>
                    </div>
                    <div className="">
                        <ul className='py-3 px-4'>
                            <li>
                                <Link to='/tableproduct'>
                                    <div className='text-white bg-[#42a5f5] font-bold text-[15px] capitalize rounded-lg gap-4 items-center w-full flex py-3 px-4 shadow-blue-500/20 '>
                                        <SiInstructables className='text-[20px]' />
                                        <p>Product</p>
                                    </div>
                                </Link>
                            </li>
                        </ul>
                    </div>
                    <div className="mx-3.5 mt-4 mb-2">
                        <p class="block antialiased font-sans text-sm leading-normal text-white font-black uppercase opacity-75">auth pages</p>
                    </div>
                    <ul className='py-3 px-4'>
                        <li>
                            <Link to='/'>
                                <div className='text-white bg-[#42a5f5] font-bold text-[15px] capitalize rounded-lg gap-4 items-center w-full flex py-3 px-4 shadow-blue-500/20 '>
                                    <FaHome className='text-[20px]' />
                                    <p>dashboard</p>
                                </div>
                            </Link>
                        </li>
                    </ul>
                </div>
            </div>
        </>
    )
}

export default Navbar