﻿/* 
 * Boost Software License - Version 1.0 - August 17th, 2003
 * 
 * Copyright (c) 2013-2014 Developed by reg [Denis Kuzmin] <entry.reg@gmail.com>
 * 
 * Permission is hereby granted, free of charge, to any person or organization
 * obtaining a copy of the software and accompanying documentation covered by
 * this license (the "Software") to use, reproduce, display, distribute,
 * execute, and transmit the Software, and to prepare derivative works of the
 * Software, and to permit third-parties to whom the Software is furnished to
 * do so, all subject to the following:
 * 
 * The copyright notices in the Software and this entire statement, including
 * the above license grant, this restriction and the following disclaimer,
 * must be included in all copies of the Software, in whole or in part, and
 * all derivative works of the Software, unless such copies or derivative
 * works are solely in the form of machine-executable object code generated by
 * a source language processor.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE, TITLE AND NON-INFRINGEMENT. IN NO EVENT
 * SHALL THE COPYRIGHT HOLDERS OR ANYONE DISTRIBUTING THE SOFTWARE BE LIABLE
 * FOR ANY DAMAGES OR OTHER LIABILITY, WHETHER IN CONTRACT, TORT OR OTHERWISE,
 * ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
 * DEALINGS IN THE SOFTWARE. 
*/

using System.Collections.Generic;

namespace net.r_eg.vsSBE.SBEScripts
{
    public interface IUserVariable
    {
        /// <summary>
        /// Getting value of user-variable by using scope of project
        /// </summary>
        /// <param name="name">variable name</param>
        /// <param name="project">project name</param>
        /// <returns>evaluated value of variable</returns>
        string get(string name, string project);

        /// <summary>
        /// Getting value of user-variable by using unique identification
        /// </summary>
        /// <param name="ident">Unique identificator</param>
        /// <returns>Evaluated value of variable</returns>
        string get(string ident);

        /// <summary>
        /// Defines user-variable
        /// Value setted as unevaluated
        /// </summary>
        /// <param name="name">variable name</param>
        /// <param name="project">project name</param>
        /// <param name="unevaluated">mixed string with unevaluated data</param>
        void set(string name, string project, string unevaluated);

        /// <summary>
        /// Evaluation user-variable with IMSBuild by using scope of project
        /// Evaluated value should be updated for variable.
        /// </summary>
        /// <param name="name">Variable name for evaluating</param>
        /// <param name="project">Project name</param>
        /// <param name="msbuild">IMSBuild objects for evaluating</param>
        void evaluate(string name, string project, MSBuild.IMSBuild msbuild);

        /// <summary>
        /// Evaluation user-variable with IMSBuild by using unique identification
        /// Evaluated value should be updated for variable.
        /// </summary>
        /// <param name="ident">Unique identificator</param>
        /// <param name="msbuild">IMSBuild objects for evaluating</param>
        void evaluate(string ident, MSBuild.IMSBuild msbuild);

        /// <summary>
        /// Evaluation user-variable with ISBEScript by using scope of project
        /// Evaluated value should be updated for variable.
        /// </summary>
        /// <param name="name">Variable name for evaluating</param>
        /// <param name="project">Project name</param>
        /// <param name="msbuild">ISBEScript objects for evaluating</param>
        void evaluate(string name, string project, ISBEScript script);

        /// <summary>
        /// Evaluation user-variable with ISBEScript by using unique identification
        /// Evaluated value should be updated for variable.
        /// </summary>
        /// <param name="ident">Unique identificator</param>
        /// <param name="msbuild">ISBEScript objects for evaluating</param>
        void evaluate(string ident, ISBEScript script);

        /// <summary>
        /// Checking for variable - completed evaluation or not
        /// by using scope of project
        /// </summary>
        /// <param name="name">Variable name</param>
        /// <param name="project">Project name</param>
        /// <returns></returns>
        bool isEvaluated(string name, string project);

        /// <summary>
        /// Checking for variable - completed evaluation or not
        /// by using unique identification
        /// </summary>
        /// <param name="ident">Unique identificator</param>
        /// <returns></returns>
        bool isEvaluated(string ident);

        /// <summary>
        /// Checking existence of variable
        /// by using scope of project
        /// </summary>
        /// <param name="name">Variable name</param>
        /// <param name="project">Project name</param>
        /// <returns></returns>
        bool isExist(string name, string project);

        /// <summary>
        /// Checking existence of variable 
        /// by using unique identification
        /// </summary>
        /// <param name="ident">Unique identificator</param>
        /// <returns></returns>
        bool isExist(string ident);

        /// <summary>
        /// Removes user-variable
        /// by using scope of project
        /// </summary>
        /// <param name="name">variable name</param>
        /// <param name="project">project name</param>
        void unset(string name, string project);

        /// <summary>
        /// Removes user-variable
        /// by using unique identification
        /// </summary>
        /// <param name="ident">Unique identificator</param>
        void unset(string ident);

        /// <summary>
        /// Removes all user-variables
        /// </summary>
        void unsetAll();

        /// <summary>
        /// Exposes the enumerator for defined names of user-variables
        /// </summary>
        IEnumerable<string> Variables { get; }
    }
}
