import React, { useEffect, useRef, useState } from "react";
import Header from '../Header'
import { Link, useNavigate } from 'react-router-dom'
import { FaUser } from 'react-icons/fa'
import { MdEmail } from 'react-icons/md'
import { BsTelephoneFill } from 'react-icons/bs'
import { RiLockPasswordFill } from 'react-icons/ri'
import Category from '../catergory'
import Footer from '../Footer'
import { postRegisterApi } from '../../app/services/authService'
import { current } from "@reduxjs/toolkit";
import Login from "../Login";


const Register = () => {
  const [username, setUserName] = useState("");
  const [lastName, setLastName] = useState("");
  const [email, setEmail] = useState("");
  const [firstName, setFirstName] = useState("");
  const [phoneNumber, setPhoneNumber] = useState("");
  const [password, setPassword] = useState("");
  const [errros, setErrros] = useState([]);

  const [confirmPassword, setConfirmPassword] = useState("");

  const navigate = useNavigate();

  const handleRegisrer = async (e) => {
      e.preventDefault();
      const data = await postRegisterApi({ username, firstName, lastName, email, phoneNumber, password, confirmPassword });
      // console.log(data);
      console.log(data.statusCode === 400)
      if (data.statusCode === 400) {
        console.log(data.errors);
        setErrros(e => [...e,...data.errors])
      } else {
        navigate("/login");
      }
  }


  return (
    <>
      <div className='bg-[#f1f0f1]'>
        <Header />
        <Category />
      </div>
      <div className="container mx-auto text-center mt-10">
        <h1 className='text-[36px] font-medium '>Tạo tài khoản</h1>
        <div className="mt-5 flex text-center justify-center">
          <form onSubmit={handleRegisrer} method="">
            <div className="flex mt-5">
              <span className='py-[10px] px-[15px] text-[14px]  text-[#555] bg-[#eee] border-[#ccc] rounded border-[1px] rounded-tr-[0px] rounded-br-[0px] border-r-0 border-t[0px] '>
                <FaUser />
              </span>
              <input value={username} onChange={(e) => setUserName(e.target.value)} type="text" className='w-[230px] py-[17px] px-[12px] text-[14px]  text-[#555] border-[#ccc] rounded-tl-[0px] rounded-bl-[0px] focus:outline rounded border-[1px] h-[34px] focus:shadow focus:outline-[#66afe9]  ' placeholder='UserName' />
            </div>
            <div className="flex mt-5">
              <span className='py-[10px] px-[15px] text-[14px]  text-[#555] bg-[#eee] border-[#ccc] rounded border-[1px] rounded-tr-[0px] rounded-br-[0px] border-r-0 border-t[0px] '>
                <FaUser />
              </span>
              <input value={firstName} onChange={(e) => setFirstName(e.target.value)} type="text" className='w-[230px] py-[17px] px-[12px] text-[14px]  text-[#555] border-[#ccc] rounded-tl-[0px] rounded-bl-[0px] focus:outline rounded border-[1px] h-[34px] focus:shadow focus:outline-[#66afe9]  ' placeholder='First Name' />
            
            </div>
            <div className="flex mt-5">
              <span className='py-[10px] px-[15px] text-[14px]  text-[#555] bg-[#eee] border-[#ccc] rounded border-[1px] rounded-tr-[0px] rounded-br-[0px] border-r-0 border-t[0px] '>
                <FaUser />
              </span>
              <input value={lastName} onChange={(e) => setLastName(e.target.value)} type="text" className='w-[230px] py-[17px] px-[12px] text-[14px]  text-[#555] border-[#ccc] rounded-tl-[0px] rounded-bl-[0px] focus:outline rounded border-[1px] h-[34px] focus:shadow focus:outline-[#66afe9]  ' placeholder='Last Name' />
            </div>
            <div className="flex mt-5">
              <span className='py-[10px] px-[15px] text-[14px]  text-[#555] bg-[#eee] border-[#ccc] rounded border-[1px] rounded-tr-[0px] rounded-br-[0px] border-r-0 border-t[0px] '>
                <MdEmail />
              </span>
              <input value={email} onChange={(e) => setEmail(e.target.value)} type="email" className='w-[230px] py-[17px] px-[15px] text-[14px]  text-[#555] border-[#ccc] rounded-tl-[0px] rounded-bl-[0px] focus:outline rounded border-[1px] h-[34px] focus:shadow focus:outline-[#66afe9]  ' placeholder='Email' />

            </div>
            <div className="flex  mt-5">
              <span className='py-[10px] px-[15px] text-[14px] text-[#555] bg-[#eee] border-[#ccc] rounded border-[1px] rounded-tr-[0px] rounded-br-[0px] border-r-0 border-t[0px] '>
                <BsTelephoneFill />
              </span>
              <input value={phoneNumber} onChange={(e) => setPhoneNumber(e.target.value)} type="text" className='w-[230px] py-[17px] px-[15px] text-[14px]  text-[#555] border-[#ccc] rounded-tl-[0px] rounded-bl-[0px] focus:outline rounded border-[1px] h-[34px] focus:shadow focus:outline-[#66afe9]  ' placeholder='Phone' />
            </div>
            <div className="flex  mt-5">
              <span className='py-[10px] px-[15px] text-[14px]  text-[#555] bg-[#eee] border-[#ccc] rounded border-[1px] rounded-tr-[0px] rounded-br-[0px] border-r-0 border-t[0px] '>
                <RiLockPasswordFill />
              </span>
              <input value={password} onChange={(e) => setPassword(e.target.value)} type="password" className='w-[230px] py-[17px] px-[15px] text-[14px]  text-[#555] border-[#ccc] rounded-tl-[0px] rounded-bl-[0px] focus:outline rounded border-[1px] h-[34px] focus:shadow focus:outline-[#66afe9]  ' placeholder='Password' />
            </div>
            <div className="flex  mt-5">
              <span className='py-[10px] px-[15px] text-[14px]  text-[#555] bg-[#eee] border-[#ccc] rounded border-[1px] rounded-tr-[0px] rounded-br-[0px] border-r-0 border-t[0px] '>
                <RiLockPasswordFill />
              </span>
              <input value={confirmPassword} onChange={(e) => setConfirmPassword(e.target.value)} type="password" className='w-[230px] py-[17px] px-[15px] text-[14px]  text-[#555] border-[#ccc] rounded-tl-[0px] rounded-bl-[0px] focus:outline rounded border-[1px] h-[34px] focus:shadow focus:outline-[#66afe9]  ' placeholder='Confirm Password' />
            </div>
            <div>{errros.map((item,index) => {
                return(
                  <p key={index}>{item.message}</p>
                );
              })}</div>
            <div className="flex gap-8 justify-center mt-8">
              <button type="submit" className='hover:bg-[black] bg-[#F0F0F0] uppercase hover:text-[white] cursor-pointer py-[7px] px-[14px] text-[14px] font-normal border-[1px] rounded-[4px] ' value="Đăng ký"> Đăng ký	</button>
              <div className="hover:bg-[black]  hover:text-[white] py-[7px] px-[14px] rounded-[5px] bg-[#ccc] ">
                <Link to='/' className="">Quay về đi</Link>
              </div>
              
            </div>

          </form>
        </div>
        <div className="mt-10">
          <Footer />
        </div>
      </div>
    </>
  )
}

export default Register