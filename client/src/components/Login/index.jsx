import { useState } from 'react'
import { useForm } from "react-hook-form";
import { MdEmail } from 'react-icons/md'
import { yupResolver } from '@hookform/resolvers/yup';
import * as yup from 'yup'
import { RiLockPasswordFill } from 'react-icons/ri'
import { useDispatch } from 'react-redux'
import { AiFillEyeInvisible, AiFillEye } from 'react-icons/ai'
import { Link, useNavigate } from 'react-router-dom'
import { postLoginApi } from '../../app/services/authService'
import Category from '../catergory'
import Footer from '../Footer'
import Header from '../Header'



const schema = yup.object().shape({
  email: yup.string("").required(),
  password: yup.string().min(4).max(20).required(),
});


const Login = () => {
  
  const { register, handleSubmit, formState: { errors } } = useForm({
    resolver: yupResolver(schema),
  });
  const navigate = useNavigate();
  const [hiddenPassword, setHiddenPassword] = useState(false)
  const [errorsState, setErrorsState] = useState([])

  const handleLogin = async (data) => {
    const response = await postLoginApi(data);
    localStorage.setItem("token", response.accessToken)
    localStorage.setItem("refreshToken", response.refreshToken)
    navigate("/");
    window.location.reload(false)
  }
  return (
    <>
      <div className='bg-[#f1f0f1]'>
        <Header />
        <Category />
      </div>
      <div className="container mx-auto text-center mt-10">
        <h1 className='text-[36px] font-medium '>Đăng nhập</h1>
        <div className="mt-5 flex text-center justify-center">
          <form onSubmit={handleSubmit(handleLogin)}>
            <div className="">
              <div className="flex">
                <span className='py-[10px] px-[15px] text-[14px]  text-[#555] bg-[#eee] border-[#ccc] rounded border-[1px] rounded-tr-[0px] rounded-br-[0px] border-r-0 border-t[0px] '>
                  <MdEmail />
                </span>
                <input {...register("email")} className='w-[270px] py-[17px] px-[15px] text-[14px]  text-[#555] border-[#ccc] rounded-tl-[0px] rounded-bl-[0px] focus:outline rounded border-[1px] h-[34px] focus:shadow focus:outline-[#66afe9]  ' placeholder='Email' />
              </div>
              <p className="ml-2 text-left text-[14px] text-red-900 ">{errors.email?.message}</p>
            </div>
            <div className="mt-5">
              <div className="flex relative ">
                <span className='py-[10px] px-[15px] text-[14px]  text-[#555] bg-[#eee] border-[#ccc] rounded border-[1px] rounded-tr-[0px] rounded-br-[0px] border-r-0 border-t[0px] '>
                  <RiLockPasswordFill />
                </span>
                <input 
                type={hiddenPassword ? "text" : "password"}
                {...register("password")} 
                className='w-[270px] py-[17px] px-[15px] text-[14px] text-[#555] border-[#ccc] rounded-tl-[0px] rounded-bl-[0px] focus:outline rounded border-[1px] h-[34px] focus:shadow focus:outline-[#66afe9]  ' placeholder='Password' />
                <div className="text-[20px] absolute top-2 right-2 cursor-pointer">
                  {
                    !hiddenPassword ? <AiFillEyeInvisible onClick={() => setHiddenPassword(e => !e)} /> : < AiFillEye onClick={() => setHiddenPassword(e => !e)} />
                  }
                </div>
              </div>
              <p className="ml-2 text-left text-[14px] text-red-900 ">{errors.password?.message}</p>
            </div>
            <div className="mt-7">
              <button type="submit" className='hover:bg-[black] bg-[#F0F0F0] uppercase hover:text-[white] cursor-pointer py-[7px] px-[14px] text-[14px] font-normal border-[1px] rounded-[4px] ' value="Đăng nhập" > Đăng nhập 		</button>
            </div>
            <div className='mt-4'>
              <Link to='/' className='text-[#428bca] hover:text-[#f45b4f]'>Quên mật khẩu? </Link>
              hoặc <Link to='/register' className='text-[#428bca] hover:text-[#f45b4f]' href="/register" title="Đăng ký">Đăng ký</Link>
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

export default Login