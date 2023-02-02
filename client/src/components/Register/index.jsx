import React, { useState } from "react";
import { useForm } from "react-hook-form";
import { yupResolver } from '@hookform/resolvers/yup';
import * as yup from 'yup'
import { AiFillEye, AiFillEyeInvisible } from 'react-icons/ai';
import { BsTelephoneFill } from 'react-icons/bs';
import { FaUser } from 'react-icons/fa';
import { MdEmail } from 'react-icons/md';
import { RiLockPasswordFill } from 'react-icons/ri';
import { Link, useNavigate } from 'react-router-dom';
import { postRegisterApi } from '../../app/services/authService';
import Category from '../catergory';
import Footer from '../Footer';
import Header from '../Header';

const schema = yup.object().shape({
  username: yup.string("").required(),
  lastName: yup.string().required(),
  firstName: yup.string().required(),
  email: yup.string().email().required(),
  phoneNumber: yup.string().min(10).required("Số điện thoại phải có ít nhất 10 ký tự"),
  password: yup.string().min(4).max(20).required(),
  confirmPassword: yup.string().oneOf([yup.ref("password"), null]),
});

const Register = () => {
  const navigate = useNavigate();
  const [hiddenPassword, setHiddenPassword] = useState(false)
  const [hiddenConfirmPassword, setHiddenConfirmPassword] = useState(false)
  const [errorsState, setErrorsState] = useState([])

  const { register, handleSubmit, formState: { errors } } = useForm({
    resolver: yupResolver(schema),
  });

  const handleRegisrer = async (data) => {
  
    // console.log(data);
    const response = await postRegisterApi(data);
    if (response.statusCode !== 400) {
      navigate("/login")
    } else {
      setErrorsState(e => [...e, ...response.errors])
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
          <form onSubmit={handleSubmit(handleRegisrer)}>
            <div className="mt-5">
              <div className="flex">
                <span className='py-[10px] px-[15px] text-[14px]  text-[#555] bg-[#eee] border-[#ccc] rounded border-[1px] rounded-tr-[0px] rounded-br-[0px] border-r-0 border-t[0px] '>
                  <FaUser />
                </span>
                <input {...register("username")} type="text" className='w-[250px] py-[17px] px-[12px] text-[14px]  text-[#555] border-[#ccc] rounded-tl-[0px] rounded-bl-[0px] focus:outline rounded border-[1px] h-[34px] focus:shadow focus:outline-[#66afe9]  ' placeholder='UserName' />
              </div>
              <p className="ml-2 text-left text-[14px] text-red-900 ">{errors.username?.message}</p>
            </div>
            <div className="mt-5">
              <div className="flex">
                <span className='py-[10px] px-[15px] text-[14px]  text-[#555] bg-[#eee] border-[#ccc] rounded border-[1px] rounded-tr-[0px] rounded-br-[0px] border-r-0 border-t[0px] '>
                  <FaUser />
                </span>
                <input {...register("lastName")} type="text" className='w-[250px] py-[17px] px-[12px] text-[14px]  text-[#555] border-[#ccc] rounded-tl-[0px] rounded-bl-[0px] focus:outline rounded border-[1px] h-[34px] focus:shadow focus:outline-[#66afe9]  ' placeholder='First Name' />
              </div>
              <p className="ml-2 text-left text-[14px] text-red-900 ">{errors.firstName?.message}</p>
            </div>
            <div className="mt-5">
              <div className="flex">
                <span className='py-[10px] px-[15px] text-[14px]  text-[#555] bg-[#eee] border-[#ccc] rounded border-[1px] rounded-tr-[0px] rounded-br-[0px] border-r-0 border-t[0px] '>
                  <FaUser />
                </span>
                <input {...register("firstName")} type="text" className='w-[250px] py-[17px] px-[12px] text-[14px]  text-[#555] border-[#ccc] rounded-tl-[0px] rounded-bl-[0px] focus:outline rounded border-[1px] h-[34px] focus:shadow focus:outline-[#66afe9]  ' placeholder='Last Name' />
              </div>
              <p className="ml-2 text-left text-[14px] text-red-900 ">{errors.lastName?.message}</p>
            </div>
            <div className=" mt-5">
              <div className="flex">
                <span className='py-[10px] px-[15px] text-[14px]  text-[#555] bg-[#eee] border-[#ccc] rounded border-[1px] rounded-tr-[0px] rounded-br-[0px] border-r-0 border-t[0px] '>
                  <MdEmail />
                </span>
                <input {...register("email")} type="email" className='w-[250px] py-[17px] px-[15px] text-[14px]  text-[#555] border-[#ccc] rounded-tl-[0px] rounded-bl-[0px] focus:outline rounded border-[1px] h-[34px] focus:shadow focus:outline-[#66afe9]  ' placeholder='Email' />
              </div>
              <p className="ml-2 text-left text-[14px] text-red-900 ">{errors.email?.message}</p>
            </div>
            <div className="mt-5">
              <div className="flex">
                <span className='py-[10px] px-[15px] text-[14px] text-[#555] bg-[#eee] border-[#ccc] rounded border-[1px] rounded-tr-[0px] rounded-br-[0px] border-r-0 border-t[0px] '>
                  <BsTelephoneFill />
                </span>
                <input {...register("phoneNumber")} type="text" className='w-[250px] py-[17px] px-[15px] text-[14px]  text-[#555] border-[#ccc] rounded-tl-[0px] rounded-bl-[0px] focus:outline rounded border-[1px] h-[34px] focus:shadow focus:outline-[#66afe9]  ' placeholder='Phone' />
              </div>
              <p className="ml-2 text-left text-[14px] text-red-900 ">{errors.phoneNumber?.message}</p>
            </div>
            <div className="mt-5">
              <div className="flex relative">
                <span className='py-[10px] px-[15px] text-[14px]  text-[#555] bg-[#eee] border-[#ccc] rounded border-[1px] rounded-tr-[0px] rounded-br-[0px] border-r-0 border-t[0px] '>
                  <RiLockPasswordFill />
                </span>
                <input
                  type={hiddenPassword ? "text" : "password"}
                  {...register("password")}
                  className='w-[250px] py-[17px] px-[15px] text-[14px]  text-[#555] border-[#ccc] rounded-tl-[0px] rounded-bl-[0px] focus:outline rounded border-[1px] h-[34px] focus:shadow focus:outline-[#66afe9]  ' placeholder='Password' />
                <div className="text-[20px] absolute top-2 right-3 cursor-pointer">
                  {
                    !hiddenPassword ? <AiFillEyeInvisible onClick={() => setHiddenPassword(e => !e)} /> : < AiFillEye onClick={() => setHiddenPassword(e => !e)} />
                  }
                </div>
              </div>
              <p className="ml-2 text-left text-[14px] text-red-900 ">{errors.password?.message}</p>
            </div>
            <div className="mt-5 ">
              <div className="flex relative">
                <span className='py-[10px] px-[15px] text-[14px]  text-[#555] bg-[#eee] border-[#ccc] rounded border-[1px] rounded-tr-[0px] rounded-br-[0px] border-r-0 border-t[0px] '>
                  <RiLockPasswordFill />
                </span>
                <input type={hiddenConfirmPassword ? "text" : "password"} {...register("confirmPassword")} className='w-[250px] py-[17px] px-[15px] text-[14px]  text-[#555] border-[#ccc] rounded-tl-[0px] rounded-bl-[0px] focus:outline rounded border-[1px] h-[34px] focus:shadow focus:outline-[#66afe9]  ' placeholder='Confirm Password' />
                <div className="text-[20px] absolute top-2 right-3 cursor-pointer">
                  {
                    !hiddenConfirmPassword ? <AiFillEyeInvisible onClick={() => setHiddenConfirmPassword(e => !e)} /> : < AiFillEye onClick={() => setHiddenConfirmPassword(e => !e)} />
                  }
                </div>
              </div>
              <p className="ml-3 w-[290px] text-left text-[14px] text-red-900 ">{errors.confirmPassword?.message}</p>
            </div>
            <div>{errorsState.map((item, index) => {
              return (
                <p key={index}>{item.message}</p>
              );
            })}</div>
            <div className="flex gap-8 justify-center mt-8">
              <button type="submit" className='hover:bg-[black] bg-[#F0F0F0] uppercase hover:text-[white] cursor-pointer py-[7px] px-[14px] text-[14px] font-normal border-[1px] rounded-[4px] ' > Đăng ký	</button>
              <div className="hover:bg-[black]  uppercase hover:text-[white] py-[7px] px-[14px] rounded-[5px] bg-[#ccc] ">
                <Link to='/' className="">Quay về</Link>
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